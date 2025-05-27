// Copyright (c) FAC. All rights reserved.
// Mammon's Calculator

// Here we have the logic stuff set up to create the actual token stream for use in our sorting algorithm later.

using System;
using System.Xml.Linq;

namespace Mammon {
    public class TokenStream {
        // Fields
        private string _input;
        private List<Token> _tokens;
        public IReadOnlyList<Token> Tokens => _tokens;
        private TokenScan _tokenscanner;
        private readonly char[] opchars = new char[] { '(', ')', '^', '*', '/', '+', '-' }; // operator character set.

        // Constructors
        public TokenStream(string input) { 
            _input = input;
            _tokens = new List<Token>();
            _tokenscanner = new TokenScan(_input);
        }

        // Methods
        public List<Token> Tokenize() { // The main logic block for our various method calls which ultimately builds the stream.
            InputType itype = InputType.None;

            while ((_tokenscanner.HasCharsRemaining)) {
                char t_opt = _tokenscanner.GetCurrentChar;

                if (char.IsDigit(t_opt)) {
                    itype = InputType.Number;
                }

                if (char.IsLetter(t_opt)) {
                    itype = InputType.Letter;
                }

                if (char.IsWhiteSpace(t_opt)) {
                    itype = InputType.None;
                }

                if (opchars.Contains(t_opt)) {
                    itype = InputType.Character;
                }

                switch (itype) {
                    case InputType.Number: {
                        NumberBuilder(_tokenscanner, _tokens);
                        break;
                    }

                    case InputType.Letter: {
                        VariableBuilder(_tokenscanner, _tokens); 
                        break;
                    }

                    case InputType.Character: {
                        OperatorBuilder(_tokenscanner, _tokens);    
                        break;
                    }

                    case InputType.None: {
                        if (_tokenscanner.HasCharsRemaining) {
                            _tokenscanner.Offset++;
                        }
                        break;
                    }

                    default: {
                        // do_otherstuff();
                        break;
                    }
                }
            }

            return _tokens;
        }

        // Builder methods build up the List<Token> stream
        private void NumberBuilder(TokenScan scanner, List<Token> tokenlist) {
            var wholenum = 0;
            var remainder = 0;

            // Converting chars to number-types.
            while (scanner.HasCharsRemaining && char.IsDigit(scanner.GetCurrentChar)) {
                var digit = scanner.GetCurrentChar - '0'; // Assuming ASCII standard. (lookin at you IBM EBCDIC mainframes -_-).
                wholenum = wholenum * 10 + digit;

                scanner.Offset++;
            }

            if (scanner.HasCharsRemaining && scanner.GetCurrentChar == '.') {
                scanner.Offset++;

                 while (scanner.HasCharsRemaining && char.IsDigit(scanner.GetCurrentChar)) { // I know this is repetetive but I want to ensure wholenum and remainder are seperate vars.
                    var digit = scanner.GetCurrentChar - '0';
                    remainder = remainder * 10 + digit;

                    scanner.Offset++;
                 }
            }

            // Here we combine wholenum and remainder to get our final decimal result:
            // 1) Determine number of digits in var 'remainder'
            // 2) Divide 'remainder' by 10^digits
            // 3) Add to wholenum for final result, e.g. 'wholenum' = 3, 'remainder' = 14, result = 3.14.
            var digits = remainder == 0 ? 1 : (int)Math.Floor(Math.Log10((double)remainder)) + 1;
            decimal scale = (decimal)Math.Pow(10, digits);
            decimal result = wholenum + (remainder / scale);

            // Build the token
            Token token = new Token(TokenType.Number, OperatorType.None, result);
            tokenlist.Add(token);

            return;
        }

        private void VariableBuilder(TokenScan scanner, List<Token> tokens) {

            return;
        }

        private void OperatorBuilder(TokenScan scanner, List<Token> tokens) {
            while (scanner.HasCharsRemaining && opchars.Contains(scanner.GetCurrentChar)) {
                switch (scanner.GetCurrentChar) {
                    case '(': {
                        Token token = new Token(TokenType.Operator, OperatorType.OpenParentheses, 0);
                        tokens.Add(token);
                        break;
                    }

                    case ')': {
                        Token token = new Token(TokenType.Operator, OperatorType.CloseParentheses, 0);
                        tokens.Add(token);
                        break;
                    }

                    case '^': {
                        Token token = new Token(TokenType.Operator, OperatorType.Exponent, 0);
                        tokens.Add(token);
                        break;
                    }

                    case '*': {
                        Token token = new Token(TokenType.Operator, OperatorType.Multiply, 0);
                        tokens.Add(token);
                        break;
                    }

                    case '/': {
                        Token token = new Token(TokenType.Operator, OperatorType.Divide, 0);
                        tokens.Add(token);
                        break;
                    }

                    case '+': {
                        Token token = new Token(TokenType.Operator, OperatorType.Add, 0);
                        tokens.Add(token);
                        break;
                    }

                    case '-': {
                        Token token = new Token(TokenType.Operator, OperatorType.Subtract, 0);
                        tokens.Add(token);
                        break;
                    }
                }

                if (scanner.HasCharsRemaining) {
                    scanner.Offset++;
                }
            }

            return;
        }
    }
}
