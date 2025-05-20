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
        UserFunction        // User-defined functions, func myFunc(x) { return x + 2; }, (x) => x^2, etc
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

    public class Token {
        public TokenType TType { get; }
        public OperatorType OpType { get; }
        public float Value; // This is meant to represent any integer value, for now it's a basic placeholder.

        public Token(TokenType tType, OperatorType opType, float value) {
            TType = tType;
            OpType = opType;
            Value = value;
        }

        public override string ToString() {
            return $"Token Type: {TType}, Operator Type: {OpType}, Value: {Value}";
        }
    }
}
