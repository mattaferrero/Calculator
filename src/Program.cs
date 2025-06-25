using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mammon;

class Program {
    public static int Main() {

        // Application.Run(new Form1());

        while (true) {
            Console.WriteLine("Enter number: ");
            var input = Console.ReadLine();

            TokenStream output = new TokenStream(input);
            output.Tokenize();

            foreach (var item in output.Tokens) {
                Console.WriteLine(item);
            }
        }

        return 0;
    }
}