// Copyright (c) FAC. All rights reserved.
// Mammon's Calculator 

using System;

namespace Mammon {
    public enum TokenType {
        Number,             // integers, floats, sci notation
        Operator,           // ( ), ^, *, /, +, -, %
        Variable,           // User-defined variables, x, y, var1, tmp, etc
        Assignment,         // '=' 
        Function,           // sqrt(x), sin(y), etc
        Constant,           // pi, e, etc
        ComparisonOp,       // ==, !=, <, >, etc
        LogicalOp,          // && (logical AND), ||, etc
        Special,            // NaN, inf/-inf, reserved tokens
        UserFunction,       // User-defined functions, func myFunc(x) { return x + 2; }, (x) => x^2, etc
        None                // reserved
    }

    public enum OperatorType {
        OpenParentheses,
        CloseParentheses,
        Exponent,
        Multiply,
        Divide,
        Add,
        Subtract,
        None                
    }

    public enum InputType {
        Letter,
        Number,
        Character,
        None
    }

    public class Token {
        // Properties and Fields
        public TokenType TType { get; }
        public OperatorType OpType { get; }
        public decimal Value; 

        // Constructors
        public Token(TokenType tType, OperatorType opType, decimal value) {
            TType = tType;
            OpType = opType;
            Value = value;
        }

        // Overrides
        public override string ToString() {
            return $"Token Type: {TType}, Operator Type: {OpType}, Value: {Value}";
        }
    }
}
