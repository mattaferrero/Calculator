using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Subtract
    }
    
    // Sorry babe I'm basically ripping you off at this point :( Mine's better though <3 (4real iluvyou)
    public static class TokenMethods { 
        public static OperatorType GetOperator(char c) {

        }

        /*
         * Okay so this looks fairly complicated, but it's just a compact and (hopefully) more efficient way
         * of converting each character '0', '1', .. '9' to its integer counterpart. There are a few different
         * ways of writing this, and some are more efficient than others. Here's a non-comprehensive list of 
         * alternative one-liners:
         * 
         * static int Pattern(char c) => c - '0' is int i and < 10 and >= 0 ? i : -1;
         * static int If(char c) { if (c >= '0' && c <= '9') return c - '0'; else return -1; }
         * static int Ternary(char c) => (c >= '0' && c <= '9') ? c - '0' : -1;
         * static int TernaryPattern(char c) => (c is >= '0' and <= '9') ? c - '0' : -1;
         * 
         * And for the least efficient but most human-readable form:
         * 
         *         switch (c)
        {
            case '0' : return 0;
            ... 
            case '9' : return 9;
            default : return -1;
        }

        The switch statement results in about 25 ish ASM instructions, the others about 6-7 ish.
        */

        public static int GetNumber(char c) {
            return (c >= '0' && c <= '9') ? c - '0' : -1;
        }
    }
}
