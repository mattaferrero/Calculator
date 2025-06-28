using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammon {
    public class Node {
        // properties and fields
        public Token MyToken { get; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public bool isTop { get; set; }
        public bool isBottom { get; set; }

        // constructors
        public Node(Token mytoken) {
            MyToken = mytoken;
        }
    }
}

