// Copyright (c) FAC. All rights reserved.
// Mammon's Calculator

// Here we have the logic stuff set up to create the actual token stream for use in our sorting algorithm later.

using System;

namespace Mammon {
    public class TokenStream {
        // Fields
        private string _input;
        private List<Token> _tokens;
        private TokenScan _tokenscanner;

        // Constructors
        public TokenStream(String input) { 
            _input = input;
            _tokens = new List<Token>();
            _tokenscanner = new TokenScan(_input);
        }

        // Methods
        public List<Token> Tokenize() { // The main logic block for our various method calls which ultimately builds the stream.
            char t_opt = _tokenscanner.GetCurrentChar;

            if (char.IsDigit(t_opt)) {
                // HandleDigits(_tokenscanner);
            }

            if (char.IsLetter(t_opt)) {
                // HandleLetters(_tokenscanner);
            }
            
            switch (t_opt) {
                case '(':
                case ')':
                case '^':
                case '*':
                case '/':
                case '+':
                case '-': {
                    // HandleOperators(_tokenscanner);
                    break;
                }

                case ' ': {
                    // HandleWhitespace();
                    break;
                }

                default: break;
            }

            return _tokens;
        }
    }
}
