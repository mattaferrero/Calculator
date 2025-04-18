using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammon {
    /* The intended usage of this class is to create a persistent object which does one thing
     * and one thing only. 
     * Return the next character in a string object each time it is called.
     * GOD KNOWS WHY THIS ISN'T IN SOME CORE LIBRARY, but /i/ sure as hell can't find an equivalent anywhere.
     */
    public class StringIterator {
        private static StringIterator? _instance;
        private string _input = string.Empty;
        private int _index = 0;

        // Locking object for thread-safety.
        private static readonly object _lock = new();

        // Private constructor to prevent external instancing.
        private StringIterator(string input) {
            _input = input ?? throw new ArgumentNullException(nameof(input));
        }

        // Static method which gets initialized only once during program execution.
        public static StringIterator CreateInstance(string input) {
            lock (_lock) {
                if (_instance == null) {
                        _instance = new StringIterator(input);
                    }

                return _instance;
            }
        }

        // Public accessor.
        public static StringIterator Instance {
            get {
                if (_instance == null) {
                    throw new InvalidOperationException("Required: Must Call CreateInstance(input)");
                }

                return _instance;
            }
        }

        public char? GetNextChar() {
            if (_index >= _input.Length) { 
                return null;
            }

            return _input[_index++]; // all that for a drop of blood..
        }

        public char? GetPrevChar() {
            return _input[_index--];
        }

        // This allows us to update the string and reset the index.
        public void ResetString(string newInput) {
            if (string.IsNullOrEmpty(newInput)) {
                throw new ArgumentNullException(nameof(newInput));
            }

            _input = newInput;
            _index = 0;
        }
    }
}
