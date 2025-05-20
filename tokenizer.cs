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

        public override string ToString() {
            return $"Token Type: {TType}, Operator Type: {OpType}, Value: {Value}";
        }
    }

    public class TokenStream {
        private string _input;
        private List<Token> _tokens;

        public List<Token> Tokenize(string input) {
            // This object MUST be created first:
            var iterator = StringIterator.CreateInstance("Avaricia"); // This string is never used, just ignore it.

            _input = input;
            _tokens = new List<Token>();
            iterator.ResetString(input);

            // This loop is where the token stream List is built from string input.
            while (iterator.GetNextChar() is char ch) {
                if (char.IsWhiteSpace(ch)) {
                    continue; // White space must be treated as a token seperator, it is ignored for now.
                }

                if ("()^*/+-".Contains(ch)) { // todo: create seperate file for string constants.
                    _tokens.Add(GetOpToken(ch));
                    continue;
                }

                if (char.IsDigit(ch)) {
                    bool d_flag = true;
                    int result = 0;

                    while (d_flag) {
                        int digit = ch - '0';
                        result = result * 10 + digit;

                        iterator.GetNextChar();

                        if (ch < '0' || ch > '9') { // just checking if ch isn't a digit.
                            d_flag = false;
                            break;
                        }
                    }

                    Token token = new Token (TokenType.Number, OperatorType.None, result);
                    _tokens.Add(token);
                }

                return _tokens;
            }

            return _tokens; // i don't think this will ever get called eh
        }

        private Token GetOpToken(char ch) {
            var optype = OperatorType.None;
            var ttype = TokenType.Operator;

            switch (ch) {
                case '(': {
                        optype = OperatorType.OpenParentheses;
                        break;
                    }

                case ')': {
                        optype = OperatorType.CloseParentheses;
                        break;
                    }

                case '^': {
                        optype = OperatorType.Exponent;
                        break;
                    }

                case '*': {
                        optype = OperatorType.Multiply;
                        break;
                    }

                case '/': {
                        optype = OperatorType.Divide;
                        break;
                    }

                case '+': {
                        optype = OperatorType.Add;
                        break;
                    }

                case '-': {
                        optype = OperatorType.Subtract;
                        break;
                    }

                default: {
                        // todo: implement ExplodeMonitor().
                        break;
                    }
            }


            Token token = new Token(ttype, optype, 0);
            return token;
        }

    }
}
