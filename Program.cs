using System;
using System.Linq.Expressions;
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

            Pterms pterms = new Pterms(expression);
            var ret = pterms.PullLinearPterms();
            foreach (string term in ret) {
                Console.WriteLine(term);
            }
        }

        return 0; // todo: add basic exception handling for garbage input. low priority.
    }
}

