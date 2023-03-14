using System.Windows.Forms;

namespace GroupProject_106
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
            panel1 = new Panel();
            button26 = new Button();
            b_Power = new Button();
            button24 = new Button();
            b_ChangeSign = new Button();
            b_X = new Button();
            b_Comma = new Button();
            b_Plus = new Button();
            b_Minus = new Button();
            b_Multiply = new Button();
            b_Divide = new Button();
            b_RightBracket = new Button();
            b_LeftBracket = new Button();
            b_Erase = new Button();
            b_Back = new Button();
            Accuracy = new NumericUpDown();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            b_6 = new Button();
            b_7 = new Button();
            b_5 = new Button();
            b_0 = new Button();
            b_9 = new Button();
            b_8 = new Button();
            b_4 = new Button();
            b_3 = new Button();
            b_2 = new Button();
            b_1 = new Button();
            b_Count = new Button();
            button22 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            Formula = new TextBox();
            UpperIntegralRange = new NumericUpDown();
            LowerIntegralRange = new NumericUpDown();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Accuracy).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpperIntegralRange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LowerIntegralRange).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button26);
            panel1.Controls.Add(b_Power);
            panel1.Controls.Add(button24);
            panel1.Controls.Add(b_ChangeSign);
            panel1.Controls.Add(b_X);
            panel1.Controls.Add(b_Comma);
            panel1.Controls.Add(b_Plus);
            panel1.Controls.Add(b_Minus);
            panel1.Controls.Add(b_Multiply);
            panel1.Controls.Add(b_Divide);
            panel1.Controls.Add(b_RightBracket);
            panel1.Controls.Add(b_LeftBracket);
            panel1.Controls.Add(b_Erase);
            panel1.Controls.Add(b_Back);
            panel1.Controls.Add(Accuracy);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(b_6);
            panel1.Controls.Add(b_7);
            panel1.Controls.Add(b_5);
            panel1.Controls.Add(b_0);
            panel1.Controls.Add(b_9);
            panel1.Controls.Add(b_8);
            panel1.Controls.Add(b_4);
            panel1.Controls.Add(b_3);
            panel1.Controls.Add(b_2);
            panel1.Controls.Add(b_1);
            panel1.Controls.Add(b_Count);
            panel1.Location = new Point(0, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 347);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button26
            // 
            button26.BackColor = SystemColors.Window;
            button26.FlatStyle = FlatStyle.Flat;
            button26.ForeColor = SystemColors.Highlight;
            button26.Location = new Point(35, 227);
            button26.Name = "button26";
            button26.Size = new Size(158, 27);
            button26.TabIndex = 38;
            button26.Text = "Const";
            button26.UseVisualStyleBackColor = false;
            button26.Click += button26_Click;
            // 
            // b_Power
            // 
            b_Power.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_Power.FlatStyle = FlatStyle.Flat;
            b_Power.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            b_Power.ForeColor = SystemColors.Highlight;
            b_Power.ImageAlign = ContentAlignment.TopCenter;
            b_Power.Location = new Point(35, 143);
            b_Power.Name = "b_Power";
            b_Power.Size = new Size(40, 37);
            b_Power.TabIndex = 37;
            b_Power.Text = "^";
            b_Power.UseVisualStyleBackColor = true;
            b_Power.Click += button25_Click;
            // 
            // button24
            // 
            button24.FlatStyle = FlatStyle.Flat;
            button24.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button24.ForeColor = SystemColors.Highlight;
            button24.Location = new Point(198, 227);
            button24.Name = "button24";
            button24.Size = new Size(59, 58);
            button24.TabIndex = 36;
            button24.Text = "⏱";
            button24.UseVisualStyleBackColor = true;
            button24.Click += button24_Click;
            // 
            // b_ChangeSign
            // 
            b_ChangeSign.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_ChangeSign.FlatStyle = FlatStyle.Flat;
            b_ChangeSign.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            b_ChangeSign.ForeColor = SystemColors.Highlight;
            b_ChangeSign.ImageAlign = ContentAlignment.TopCenter;
            b_ChangeSign.Location = new Point(80, 142);
            b_ChangeSign.Name = "b_ChangeSign";
            b_ChangeSign.Size = new Size(40, 37);
            b_ChangeSign.TabIndex = 35;
            b_ChangeSign.Text = "+/-";
            b_ChangeSign.UseVisualStyleBackColor = true;
            b_ChangeSign.Click += button23_Click;
            // 
            // b_X
            // 
            b_X.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_X.FlatStyle = FlatStyle.Flat;
            b_X.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_X.ForeColor = SystemColors.Highlight;
            b_X.ImageAlign = ContentAlignment.TopCenter;
            b_X.Location = new Point(172, 142);
            b_X.Name = "b_X";
            b_X.Size = new Size(40, 37);
            b_X.TabIndex = 33;
            b_X.Text = "x";
            b_X.UseVisualStyleBackColor = true;
            b_X.Click += button21_Click;
            // 
            // b_Comma
            // 
            b_Comma.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_Comma.FlatStyle = FlatStyle.Flat;
            b_Comma.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            b_Comma.ForeColor = SystemColors.Highlight;
            b_Comma.ImageAlign = ContentAlignment.TopCenter;
            b_Comma.Location = new Point(125, 142);
            b_Comma.Name = "b_Comma";
            b_Comma.Size = new Size(40, 37);
            b_Comma.TabIndex = 32;
            b_Comma.Text = ",";
            b_Comma.UseVisualStyleBackColor = true;
            b_Comma.Click += button7_Click;
            // 
            // b_Plus
            // 
            b_Plus.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            b_Plus.FlatStyle = FlatStyle.Flat;
            b_Plus.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            b_Plus.ForeColor = SystemColors.Highlight;
            b_Plus.Location = new Point(239, 3);
            b_Plus.Name = "b_Plus";
            b_Plus.Size = new Size(32, 33);
            b_Plus.TabIndex = 31;
            b_Plus.Text = "+";
            b_Plus.UseVisualStyleBackColor = true;
            b_Plus.Click += button6_Click;
            // 
            // b_Minus
            // 
            b_Minus.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            b_Minus.FlatStyle = FlatStyle.Flat;
            b_Minus.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            b_Minus.ForeColor = SystemColors.Highlight;
            b_Minus.Location = new Point(201, 3);
            b_Minus.Name = "b_Minus";
            b_Minus.Size = new Size(32, 33);
            b_Minus.TabIndex = 30;
            b_Minus.Text = "-";
            b_Minus.UseVisualStyleBackColor = true;
            b_Minus.Click += button6_Click;
            // 
            // b_Multiply
            // 
            b_Multiply.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            b_Multiply.FlatStyle = FlatStyle.Flat;
            b_Multiply.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            b_Multiply.ForeColor = SystemColors.Highlight;
            b_Multiply.Location = new Point(163, 3);
            b_Multiply.Name = "b_Multiply";
            b_Multiply.Size = new Size(32, 33);
            b_Multiply.TabIndex = 29;
            b_Multiply.Text = "*";
            b_Multiply.UseVisualStyleBackColor = true;
            b_Multiply.Click += button6_Click;
            // 
            // b_Divide
            // 
            b_Divide.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            b_Divide.FlatStyle = FlatStyle.Flat;
            b_Divide.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b_Divide.ForeColor = SystemColors.Highlight;
            b_Divide.Location = new Point(125, 3);
            b_Divide.Name = "b_Divide";
            b_Divide.Size = new Size(32, 33);
            b_Divide.TabIndex = 28;
            b_Divide.Text = "/";
            b_Divide.UseVisualStyleBackColor = true;
            b_Divide.Click += button6_Click;
            // 
            // b_RightBracket
            // 
            b_RightBracket.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            b_RightBracket.FlatStyle = FlatStyle.Flat;
            b_RightBracket.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b_RightBracket.ForeColor = SystemColors.Highlight;
            b_RightBracket.Location = new Point(87, 3);
            b_RightBracket.Name = "b_RightBracket";
            b_RightBracket.Size = new Size(32, 33);
            b_RightBracket.TabIndex = 27;
            b_RightBracket.Text = ")";
            b_RightBracket.UseVisualStyleBackColor = true;
            b_RightBracket.Click += button2_Click;
            // 
            // b_LeftBracket
            // 
            b_LeftBracket.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            b_LeftBracket.FlatStyle = FlatStyle.Flat;
            b_LeftBracket.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b_LeftBracket.ForeColor = SystemColors.Highlight;
            b_LeftBracket.Location = new Point(49, 3);
            b_LeftBracket.Name = "b_LeftBracket";
            b_LeftBracket.Size = new Size(32, 33);
            b_LeftBracket.TabIndex = 26;
            b_LeftBracket.Text = "(";
            b_LeftBracket.UseVisualStyleBackColor = true;
            b_LeftBracket.Click += button2_Click;
            // 
            // b_Erase
            // 
            b_Erase.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            b_Erase.FlatStyle = FlatStyle.Flat;
            b_Erase.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            b_Erase.ForeColor = SystemColors.Highlight;
            b_Erase.Location = new Point(11, 3);
            b_Erase.Name = "b_Erase";
            b_Erase.Size = new Size(32, 33);
            b_Erase.TabIndex = 25;
            b_Erase.Text = "C";
            b_Erase.UseVisualStyleBackColor = true;
            b_Erase.Click += button20_Click;
            // 
            // b_Back
            // 
            b_Back.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_Back.FlatStyle = FlatStyle.Flat;
            b_Back.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            b_Back.ForeColor = SystemColors.Highlight;
            b_Back.ImageAlign = ContentAlignment.TopCenter;
            b_Back.Location = new Point(219, 142);
            b_Back.Name = "b_Back";
            b_Back.Size = new Size(40, 37);
            b_Back.TabIndex = 24;
            b_Back.Text = "⏴";
            b_Back.TextAlign = ContentAlignment.TopCenter;
            b_Back.UseVisualStyleBackColor = true;
            b_Back.Click += button19_Click;
            // 
            // Accuracy
            // 
            Accuracy.DecimalPlaces = 3;
            Accuracy.ForeColor = SystemColors.Highlight;
            Accuracy.Location = new Point(106, 258);
            Accuracy.Name = "Accuracy";
            Accuracy.Size = new Size(87, 27);
            Accuracy.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = SystemColors.Highlight;
            textBox2.Location = new Point(35, 260);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(65, 20);
            textBox2.TabIndex = 21;
            textBox2.Text = "Accuracy:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.HighlightText;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = SystemColors.Highlight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "sin()", "cos()", "tg()", "ctg()", "ln()", "log(x,y)", "pi", "e", "const" });
            comboBox1.Location = new Point(35, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 25);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Functions";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // b_6
            // 
            b_6.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_6.FlatStyle = FlatStyle.Flat;
            b_6.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_6.ForeColor = SystemColors.Highlight;
            b_6.Location = new Point(35, 100);
            b_6.Name = "b_6";
            b_6.Size = new Size(40, 37);
            b_6.TabIndex = 10;
            b_6.Text = "6";
            b_6.UseVisualStyleBackColor = true;
            b_6.Click += button18_Click;
            // 
            // b_7
            // 
            b_7.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_7.FlatStyle = FlatStyle.Flat;
            b_7.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_7.ForeColor = SystemColors.Highlight;
            b_7.Location = new Point(80, 100);
            b_7.Name = "b_7";
            b_7.Size = new Size(40, 37);
            b_7.TabIndex = 9;
            b_7.Text = "7";
            b_7.UseVisualStyleBackColor = true;
            b_7.Click += button17_Click;
            // 
            // b_5
            // 
            b_5.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_5.FlatStyle = FlatStyle.Flat;
            b_5.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_5.ForeColor = SystemColors.Highlight;
            b_5.Location = new Point(219, 57);
            b_5.Name = "b_5";
            b_5.Size = new Size(40, 37);
            b_5.TabIndex = 8;
            b_5.Text = "5";
            b_5.UseVisualStyleBackColor = true;
            b_5.Click += button16_Click;
            // 
            // b_0
            // 
            b_0.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_0.FlatStyle = FlatStyle.Flat;
            b_0.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_0.ForeColor = SystemColors.Highlight;
            b_0.Location = new Point(219, 100);
            b_0.Name = "b_0";
            b_0.Size = new Size(40, 37);
            b_0.TabIndex = 7;
            b_0.Text = "0";
            b_0.UseVisualStyleBackColor = true;
            b_0.Click += button15_Click;
            // 
            // b_9
            // 
            b_9.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_9.FlatStyle = FlatStyle.Flat;
            b_9.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_9.ForeColor = SystemColors.Highlight;
            b_9.Location = new Point(172, 100);
            b_9.Name = "b_9";
            b_9.Size = new Size(40, 37);
            b_9.TabIndex = 6;
            b_9.Text = "9";
            b_9.UseVisualStyleBackColor = true;
            b_9.Click += button14_Click;
            // 
            // b_8
            // 
            b_8.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_8.FlatStyle = FlatStyle.Flat;
            b_8.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_8.ForeColor = SystemColors.Highlight;
            b_8.Location = new Point(125, 100);
            b_8.Name = "b_8";
            b_8.Size = new Size(40, 37);
            b_8.TabIndex = 5;
            b_8.Text = "8";
            b_8.UseVisualStyleBackColor = true;
            b_8.Click += button13_Click;
            // 
            // b_4
            // 
            b_4.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_4.FlatStyle = FlatStyle.Flat;
            b_4.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_4.ForeColor = SystemColors.Highlight;
            b_4.Location = new Point(172, 57);
            b_4.Name = "b_4";
            b_4.Size = new Size(40, 37);
            b_4.TabIndex = 4;
            b_4.Text = "4";
            b_4.UseVisualStyleBackColor = true;
            b_4.Click += button12_Click;
            // 
            // b_3
            // 
            b_3.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_3.FlatStyle = FlatStyle.Flat;
            b_3.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_3.ForeColor = SystemColors.Highlight;
            b_3.Location = new Point(125, 57);
            b_3.Name = "b_3";
            b_3.Size = new Size(40, 37);
            b_3.TabIndex = 3;
            b_3.Text = "3";
            b_3.UseVisualStyleBackColor = true;
            b_3.Click += button11_Click;
            // 
            // b_2
            // 
            b_2.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_2.FlatStyle = FlatStyle.Flat;
            b_2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_2.ForeColor = SystemColors.Highlight;
            b_2.Location = new Point(80, 57);
            b_2.Name = "b_2";
            b_2.Size = new Size(40, 37);
            b_2.TabIndex = 2;
            b_2.Text = "2";
            b_2.UseVisualStyleBackColor = true;
            b_2.Click += button10_Click;
            // 
            // b_1
            // 
            b_1.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_1.FlatStyle = FlatStyle.Flat;
            b_1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_1.ForeColor = SystemColors.Highlight;
            b_1.Location = new Point(35, 57);
            b_1.Name = "b_1";
            b_1.Size = new Size(40, 37);
            b_1.TabIndex = 1;
            b_1.Text = "1";
            b_1.UseVisualStyleBackColor = true;
            b_1.Click += button9_Click;
            // 
            // b_Count
            // 
            b_Count.BackColor = SystemColors.Highlight;
            b_Count.FlatStyle = FlatStyle.Flat;
            b_Count.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            b_Count.ForeColor = SystemColors.ButtonHighlight;
            b_Count.Location = new Point(0, 304);
            b_Count.Name = "b_Count";
            b_Count.Size = new Size(292, 43);
            b_Count.TabIndex = 0;
            b_Count.Text = "Count In Mind";
            b_Count.UseVisualStyleBackColor = false;
            b_Count.Click += Count_Click;
            // 
            // button22
            // 
            button22.Location = new Point(0, 0);
            button22.Name = "button22";
            button22.Size = new Size(75, 23);
            button22.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Formula);
            panel2.Controls.Add(UpperIntegralRange);
            panel2.Controls.Add(LowerIntegralRange);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 97);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(259, 30);
            label2.Name = "label2";
            label2.Size = new Size(35, 26);
            label2.TabIndex = 4;
            label2.Text = "dx";
            // 
            // Formula
            // 
            Formula.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Formula.ForeColor = SystemColors.Highlight;
            Formula.Location = new Point(101, 28);
            Formula.Name = "Formula";
            Formula.Size = new Size(156, 30);
            Formula.TabIndex = 3;
            Formula.TextChanged += Formula_TextChanged;
            // 
            // UpperIntegralRange
            // 
            UpperIntegralRange.BorderStyle = BorderStyle.None;
            UpperIntegralRange.DecimalPlaces = 1;
            UpperIntegralRange.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UpperIntegralRange.ForeColor = SystemColors.Highlight;
            UpperIntegralRange.Location = new Point(12, 8);
            UpperIntegralRange.Name = "UpperIntegralRange";
            UpperIntegralRange.Size = new Size(47, 21);
            UpperIntegralRange.TabIndex = 2;
            UpperIntegralRange.ValueChanged += UpperIntegralRange_ValueChanged;
            // 
            // LowerIntegralRange
            // 
            LowerIntegralRange.BorderStyle = BorderStyle.None;
            LowerIntegralRange.DecimalPlaces = 1;
            LowerIntegralRange.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LowerIntegralRange.ForeColor = SystemColors.Highlight;
            LowerIntegralRange.Location = new Point(12, 57);
            LowerIntegralRange.Name = "LowerIntegralRange";
            LowerIntegralRange.Size = new Size(47, 21);
            LowerIntegralRange.TabIndex = 1;
            LowerIntegralRange.ValueChanged += LowerIntegralRange_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(65, 5);
            label1.Name = "label1";
            label1.Size = new Size(50, 76);
            label1.TabIndex = 1;
            label1.Text = "∫";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1063, 450);
            Controls.Add(panel2);
            Controls.Add(button22);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Accuracy).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UpperIntegralRange).EndInit();
            ((System.ComponentModel.ISupportInitialize)LowerIntegralRange).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button b_Count;
        private Button b_5;
        private Button b_0;
        private Button b_9;
        private Button b_8;
        private Button b_4;
        private Button b_3;
        private Button b_2;
        private Button b_1;
        private Button b_6;
        private Button b_7;
        private ComboBox comboBox1;
        private NumericUpDown Accuracy;
        private TextBox textBox2;
        private Button b_Back;
        private Label label1;
        private Label label2;
        private TextBox Formula;
        private NumericUpDown UpperIntegralRange;
        private NumericUpDown LowerIntegralRange;
        private Button b_Comma;
        private Button b_Plus;
        private Button b_Minus;
        private Button b_Multiply;
        private Button b_Divide;
        private Button b_RightBracket;
        private Button b_LeftBracket;
        private Button b_Erase;
        private Button button22;
        private Button b_X;
        private Button b_ChangeSign;
        private Button button24;
        private Button b_Power;
        private Button button26;
    }
}