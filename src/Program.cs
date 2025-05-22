using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mammon;

class Program {
    public static int Main() {
        Console.WriteLine("Enter number: ");
        var input = Console.ReadLine();

        TokenStream output = new TokenStream(input);
        output.Tokenize();

        foreach (var item in output._tokens) {
            Console.WriteLine(item);
        }

        return 0;
    }
}