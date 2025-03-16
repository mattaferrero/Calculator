using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammon { 
    // ideas: Solve(), Rewrite(), Factor(), Graph() etc.
    public class Expression {
        private readonly string? _expression;

        public Expression(string? expression) {
            if (string.IsNullOrEmpty(expression)) {
                throw new ArgumentException("Passing valid string object to class Expression is required.");
            }

            _expression = expression;
        }

        

    }
}
