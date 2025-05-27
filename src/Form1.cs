﻿using System;
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

            // Numeric button handler
            button0.Click += NumpadAppend_Click();
        }

        private void NumpadAppend_Click(object sender, EventArgs e) {
            if (sender is Button clickedButton) {
                textBox1.Text += clickedButton.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
