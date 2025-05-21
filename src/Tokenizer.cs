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

        // probably should put these in a seperate file later.
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
            char t_opt = _tokenscanner.GetCurrentChar;

            if (char.IsDigit(t_opt)) {
                itype = InputType.Number;
            }

            if (char.IsLetter(t_opt)) {
                itype = InputType.Letter;
            }

            if (opchars.Contains(t_opt)) {
                itype = InputType.Character;
            }

                switch (itype) {
                    case InputType.Number: {
                        // number();
                        break;
                    }

                    case InputType.Letter: {
                        // letter(); 
                        break;
                    }

                    case InputType.Character: {
                        // Character();    
                        break;
                    }

                    case InputType.None: {
                        // dostuff();
                        break;
                    }

                    default: {
                        // do_otherstuff();
                        break;
                    }
                }

            return _tokens;
        }
    }
}
