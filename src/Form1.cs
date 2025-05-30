using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mammon {
    public partial class Form1 : Form {

        private readonly TokenStream _tokenStream;

        public Form1() {
            InitializeComponent();
            _tokenStream = new TokenStream("Avaricia");
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void numpad_Click(object sender, EventArgs e) {
            // Directly casting here is fine, need program to crash if handler changes
            Button clicked_button = (Button)sender;

            textBox1.Text += clicked_button.Text;
        }
    }
}
