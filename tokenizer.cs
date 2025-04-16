using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammon {
    public class Token {
        public TokenType TType { get; }
        public OperatorType OpType { get; }
        public float Value;

        public Token(TokenType tType, OperatorType opType, float value) {
            TType = tType;
            OpType = opType;
            Value = value;
        }
    }

    public class TokenStream {
        private string _input;
        private int _pos;
        private List<Token> _tokens;

        public List<Token> Tokenize(string input) {
            _input = input;
            _pos = 0;
            _tokens = new List<Token>();

            // I really hate this giant logic tree, but i'll find a way to improve on it later.
            // For now, here's a bigass if block.
            while (_pos < _input.Length) {
                char current = _input[_pos];

                if (char.IsWhiteSpace(current)) {
                    _pos++;
                    continue;
                }

                if (char.IsDigit(current)) {
                    _tokens.Add(ReadNumber(current));
                }

                if ("()^*/+-".Contains(current)) {
                    _tokens.Add(ReadOperator());
                }

                else {
                    throw new Exception($"ERROR WARNING ERROR: SYSTEM ERROR! INVALID INPUT: {current}. PERFORMING EMERGENCY DIAGNOSTICS. SETTING LOG. SHUTTING DOWN.");
                    // todo: write code to violently turn computer off.
                }
            }

            return _tokens;
        }

        private Token ReadNumber(char c) {
            var sb = new StringBuilder();

            while (_pos < _input.Length && char.IsDigit(_input[_pos])) {
                sb.Append(_input[_pos]);
                _pos++;
                continue;
            }

            int tmp_val = Convert.ToInt32(sb.ToString());
            float val = (float)tmp_val; // casting is appropriate here.

            Token token = new Token();
        }
    }
}
