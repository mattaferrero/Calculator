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

                if (char.IsDigit(ch)) { // todo: write comment explaining logic here. when hell freezes over. you don't deserve to know my thoughts.
                    var sb = new StringBuilder();

                    while (iterator.GetNextChar() != null) {

                        sb.Append(ch);
                        iterator.GetNextChar();
                    }

                    int tmp = Convert.ToInt32(sb.ToString());
                    float val = (float)tmp; // Casting is appropriate here.

                    Token token = new Token(TokenType.Number, OperatorType.None, val);
                    _tokens.Add(token);

                    iterator.GetPrevChar(); // We don't know how many digits the number is going to be, so we're just de-incrementing the string index by one.

                    continue;
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

        private Token GetNumToken(char ch) {
            var optype = OperatorType.None;
            var ttype = TokenType.Number;
            var val = 0;

            switch (ch) {
                case '0': { val = 0; break; }
                case '1': { val = 1; break; }
                case '2': { val = 2; break; }
                case '3': { val = 3; break; }
                case '4': { val = 4; break; }
                case '5': { val = 5; break; }
                case '6': { val = 6; break; }
                case '7': { val = 7; break; }
                case '8': { val = 8; break; }
                case '9': { val = 9; break; }
                default: { break; }
            }

            Token token = new Token(ttype, optype, val);
            return token;
        }
    }
}
