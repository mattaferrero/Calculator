using System;
using System.Collections.Generic;
using System.Data;
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

        // Method EvalPterms() first performs calculations on each List<string> entry in _pterms.
        // It then stores and returns the calculated results in a List<float>.
        // Note: DataTable.Compute() only supports basic arithmetic operations, use PullPterms() for advanced math.
        public List<float> EvalPterms() { 
            Pterms ptermsClassObj = new Pterms(_expression);
            List<string> pterms = ptermsClassObj.PullLinearPterms();

            if (!pterms.Any()) {
                Console.WriteLine("Error: No parentheticals detected, returning empty List<float>");
                return new List<float>();
            }

            List<float> ret = new List<float>();

            foreach (var p in pterms) {
                try {
                    var output = new DataTable().Compute(p, null); // perform the actual calculation from the string.
                    ret.Add(Convert.ToSingle(output)); // convert to float.
                }

                catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                    ret.Add(float.NaN); // Store NaN for invalid expressions.
                }
            }

            return ret;
        }

        public int Solve() {


            return 0;
        }
    }
}
