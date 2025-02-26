using System;
using System.Runtime.CompilerServices;

// ideas: Solve(), Rewrite(), Factor(), Graph() etc.

public class Expression {
    private readonly string _expression;

    public Expression(string expression) {
        if (string.IsNullOrEmpty(expression)) {
            throw new ArgumentException("Passing valid string object to class Expression is required.");
        }

        _expression = expression;
    }

    // These internal/private class members and data structures are used for restructuring an arithmetic or algebraic mathematical expression without using tokens.
    // This is an experimental algorithm for use in benchmark testing, and no guarantees are made as to its efficiency or accuracy.

    //private struct pstack {
    //    public int X;
    //    public int Y;

    //    public pstack(int x, int y) {
    //        X = x;
    //        Y = y;
    //    }
    //} 

    private int PStacker() {


        return 0;
    }

    private int Parse() {
        var target1 = '(';
        var target2 = ')';
        // var ret = 0;

        var index1 = _expression.IndexOf(target1);
        var index2 = _expression.IndexOf(target2);

        if (index1 != -1 || index2 != -1) { // sanity checking for matching parentheticals.
            var ctr1 = 0;
            var ctr2 = 0;

            for (var i = 0; i < _expression.Length; i++) {
                if (_expression[i] == target1) {
                    ctr1++;
                }

                if (_expression[i] == target2) {
                    ctr2++;
                }
            }

            if ((ctr1 - ctr2 != 0) || (ctr2 - ctr1 != 0)) { // is this ok?
                Console.WriteLine("Error: mismatching parentheses ( ).");

                return 1;
            }

            // ret = PStacker(); 
        }

        return 0;
    }

}

public static class Program {

    public static int Main() {
        while (true) {
            Console.WriteLine("Enter a valid math expression ('q' to quit): ");
            string expression = Console.ReadLine();

            if (expression == "q") {
                break;
            }

            // Expression(string s); must be called before any other methods from class Expression
        }

        return 0; // todo: add basic exception handling for garbage input. low priority.
    }

}

