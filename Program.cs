﻿using System;
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

            // Expression(string s); must be called before any other methods from class Expression

            Pterms ptermsClassObj = new Pterms(expression);
            List<string> pterms = ptermsClassObj.PullLinearPterms();

            foreach (string s in pterms) {
                Console.WriteLine(s);
            }
        }

        return 0; // todo: add basic exception handling for garbage input. low priority.
    }
}

