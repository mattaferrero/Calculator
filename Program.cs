using System;
using System.Runtime.CompilerServices;

using Mammon;

public static class Program {

    public static int Main() {
        while (true) {
            Console.WriteLine("Enter a valid math expression ('q' to quit): ");
            string expression = Console.ReadLine() ?? "";

            if (expression == "q") {
                break;
            }

            var exp = expression.Replace(" ", string.Empty); // todo: performance check here

            Expression expressionClassObj = new Mammon.Expression(expression);
            var evaluated = expressionClassObj.EvalPterms();

            foreach (float item in evaluated) {
                Console.WriteLine(item);
            }

        }

        return 0; // todo: add basic exception handling for garbage input. low priority.
    }
}

