using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammon {
    class Program {
        static int Main(string[] args) {
            TokenStream stream = new TokenStream();

            while (true) {
                Console.WriteLine("Enter Expression: ");
                var input = Console.ReadLine();
                var output = stream.Tokenize(input);

                foreach (var item in output) {
                    Console.WriteLine(item);
                }
            }

            return 0;
        }
    }
}
