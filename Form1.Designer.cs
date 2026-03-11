namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            a1X = new TextBox();
            a2Y = new TextBox();
            a3Z = new TextBox();
            b1X = new TextBox();
            b2Y = new TextBox();
            b3Z = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            operationBox = new ComboBox();
            lengthABox = new TextBox();
            lengthBBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            resultsBox1 = new TextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 32);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 0;
            label1.Text = "a1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 32);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 1;
            label2.Text = "a2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 32);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 2;
            label3.Text = "a3";
            // 
            // a1X
            // 
            a1X.Location = new Point(28, 60);
            a1X.Name = "a1X";
            a1X.Size = new Size(100, 23);
            a1X.TabIndex = 4;
            // 
            // a2Y
            // 
            a2Y.Location = new Point(134, 60);
            a2Y.Name = "a2Y";
            a2Y.Size = new Size(100, 23);
            a2Y.TabIndex = 5;
            // 
            // a3Z
            // 
            a3Z.Location = new Point(240, 60);
            a3Z.Name = "a3Z";
            a3Z.Size = new Size(100, 23);
            a3Z.TabIndex = 6;
            // 
            // b1X
            // 
            b1X.Location = new Point(28, 122);
            b1X.Name = "b1X";
            b1X.Size = new Size(100, 23);
            b1X.TabIndex = 7;
            // 
            // b2Y
            // 
            b2Y.Location = new Point(134, 122);
            b2Y.Name = "b2Y";
            b2Y.Size = new Size(100, 23);
            b2Y.TabIndex = 8;
            // 
            // b3Z
            // 
            b3Z.Location = new Point(240, 122);
            b3Z.Name = "b3Z";
            b3Z.Size = new Size(100, 23);
            b3Z.TabIndex = 9;
            b3Z.TextChanged += textBox6_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 104);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 10;
            label4.Text = "b1";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 104);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 11;
            label5.Text = "b2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 104);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 12;
            label6.Text = "b3";
            label6.Click += label6_Click;
            // 
            // operationBox
            // 
            operationBox.AutoCompleteCustomSource.AddRange(new string[] { "+", "-", "scalar", "Cross" });
            operationBox.FormattingEnabled = true;
            operationBox.Location = new Point(371, 96);
            operationBox.Name = "operationBox";
            operationBox.Size = new Size(121, 23);
            operationBox.TabIndex = 13;
            // 
            // lengthABox
            // 
            lengthABox.Location = new Point(371, 167);
            lengthABox.Name = "lengthABox";
            lengthABox.ReadOnly = true;
            lengthABox.Size = new Size(100, 23);
            lengthABox.TabIndex = 14;
            // 
            // lengthBBox
            // 
            lengthBBox.Location = new Point(371, 217);
            lengthBBox.Name = "lengthBBox";
            lengthBBox.ReadOnly = true;
            lengthBBox.Size = new Size(100, 23);
            lengthBBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(371, 149);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 16;
            label7.Text = "Length A";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(371, 199);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 17;
            label8.Text = "Length B";
            // 
            // resultsBox1
            // 
            resultsBox1.Location = new Point(28, 191);
            resultsBox1.Name = "resultsBox1";
            resultsBox1.ReadOnly = true;
            resultsBox1.Size = new Size(100, 23);
            resultsBox1.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(162, 167);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 19;
            label9.Text = "Results";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 191);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 191);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 273);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(resultsBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lengthBBox);
            Controls.Add(lengthABox);
            Controls.Add(operationBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(b3Z);
            Controls.Add(b2Y);
            Controls.Add(b1X);
            Controls.Add(a3Z);
            Controls.Add(a2Y);
            Controls.Add(a1X);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox a1X;
        private TextBox a2Y;
        private TextBox a3Z;
        private TextBox b1X;
        private TextBox b2Y;
        private TextBox b3Z;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox operationBox;
        private TextBox lengthABox;
        private TextBox lengthBBox;
        private Label label7;
        private Label label8;
        private TextBox resultsBox1;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
