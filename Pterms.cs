using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammon {
    //
    class Pterms {
        private readonly string? _expression;

        public Pterms(string? expression) {
            if (expression == null) {
                throw new ArgumentException("List<string> is null or empty, class Pterms requires valid List<string> object.");
            }

            _expression = expression;
        }

        // For use in non-nested parenthetical expressions.
        // Example: (1+1) / (2+2) is "linear"
        // ((1+1) / 2) is "nested" and support for nested expressions will be implemented in PullPterms().
        public List<string> PullLinearPterms() {
            StringChunks stringChunks = new StringChunks();

            // Get the indexes of all '(' and ')' characters in _pterms.
            List<int> open_p = stringChunks.PullCharIndexes(_expression, '(');
            List<int> close_p = stringChunks.PullCharIndexes(_expression, ')');

            // Get the substrings of all characters between the indexes of open_p and close_p.
            List<string> pterms = stringChunks.PullStringChunk(_expression, open_p, close_p);

            return pterms;
        }
    }
}