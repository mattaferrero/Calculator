namespace Mammon {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            expInput = new TextBox();
            enterInput = new Button();
            SuspendLayout();
            // 
            // expInput
            // 
            expInput.Location = new Point(288, 123);
            expInput.Name = "expInput";
            expInput.Size = new Size(125, 27);
            expInput.TabIndex = 0;
            expInput.TextChanged += textBox1_TextChanged;
            // 
            // enterInput
            // 
            enterInput.Location = new Point(419, 121);
            enterInput.Name = "enterInput";
            enterInput.Size = new Size(94, 29);
            enterInput.TabIndex = 1;
            enterInput.Text = "button1";
            enterInput.UseVisualStyleBackColor = true;
            enterInput.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(enterInput);
            Controls.Add(expInput);
            Name = "Form1";
            Text = "Mammon Prototype";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox expInput;
        private Button enterInput;
    }
}