// Copyright (c) FAC. All rights reserved.
// Mammon's Calculator

// This class is just used to keep track of the input string information:
// last index accessed, remaining subsets etc.
using System;

namespace Mammon {
    public class TokenScan {
        // Fields
        private string _input;

        // Constructors
        public TokenScan(string input) {
            _input = input;
        }

        // Properties
        public int Offset { get; set; } = 0;

        public string Str {
            get {  return _input; }
            set { _input = value; }
        }

        public char GetCurrentChar {
            get { return Str[Offset]; }
        }
        public bool HasCharsRemaining {
            get { return (Str.Length > Offset); }
        }
        public string GetRemainingInput {
            get { return Str.Substring(Offset); }
        }
    }
}
