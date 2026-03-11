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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox9 = new TextBox();
            label9 = new Label();
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
            // textBox1
            // 
            textBox1.Location = new Point(28, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(240, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(28, 122);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(134, 122);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(240, 122);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 9;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(371, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(371, 167);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 14;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(371, 217);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 15;
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
            // textBox9
            // 
            textBox9.Location = new Point(28, 191);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(312, 23);
            textBox9.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(158, 167);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 19;
            label9.Text = "Results";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 273);
            Controls.Add(label9);
            Controls.Add(textBox9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label7;
        private Label label8;
        private TextBox textBox9;
        private Label label9;
    }
}
