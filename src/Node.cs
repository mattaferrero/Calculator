using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammon {
    public class Node {
        // properties and fields
        public TokenStream token_stream { get; }

        // constructors
        public Node() {
        }

        public Node(TokenStream ast_stream) {
            token_stream = ast_stream;
        }

        // AST stuff
        public int BuildTree() {
            bool isTopNode = false;
            bool isLastNode = false;
            bool isSplitNode = false;

            var stream_len = token_stream.Tokens.Count;

            for (var ctr = 0; ctr < stream_len; ctr++) {
                if (ctr == 0) {
                    isTopNode = true;
                }

                if (ctr == stream_len) {
                    isLastNode = true;
                }
            }

            return 0;
        }
    }
}
