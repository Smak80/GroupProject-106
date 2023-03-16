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
            label6 = new Label();
            button26 = new Button();
            b_Power = new Button();
            button24 = new Button();
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
            l_time = new Label();
            label2 = new Label();
            Formula = new TextBox();
            UpperIntegralRange = new NumericUpDown();
            LowerIntegralRange = new NumericUpDown();
            label1 = new Label();
            GraphPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            YMax = new NumericUpDown();
            label4 = new Label();
            YMin = new NumericUpDown();
            l_x = new Label();
            l_y = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            l_Result = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Accuracy).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpperIntegralRange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LowerIntegralRange).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YMin).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button26);
            panel1.Controls.Add(b_Power);
            panel1.Controls.Add(button24);
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
            panel1.Location = new Point(8, 234);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 431);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(59, 234);
            label6.Name = "label6";
            label6.Size = new Size(96, 21);
            label6.TabIndex = 39;
            label6.Text = "Functions";
            // 
            // button26
            // 
            button26.BackColor = SystemColors.Window;
            button26.FlatStyle = FlatStyle.Flat;
            button26.ForeColor = SystemColors.Highlight;
            button26.Location = new Point(49, 270);
            button26.Margin = new Padding(4);
            button26.Name = "button26";
            button26.Size = new Size(198, 34);
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
            b_Power.Location = new Point(80, 178);
            b_Power.Margin = new Padding(4);
            b_Power.Name = "b_Power";
            b_Power.Size = new Size(50, 46);
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
            button24.Location = new Point(252, 270);
            button24.Margin = new Padding(4);
            button24.Name = "button24";
            button24.Size = new Size(74, 72);
            button24.TabIndex = 36;
            button24.Text = "⏱";
            button24.UseVisualStyleBackColor = true;
            button24.Click += button24_Click;
            // 
            // b_X
            // 
            b_X.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_X.FlatStyle = FlatStyle.Flat;
            b_X.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_X.ForeColor = SystemColors.Highlight;
            b_X.ImageAlign = ContentAlignment.TopCenter;
            b_X.Location = new Point(196, 176);
            b_X.Margin = new Padding(4);
            b_X.Name = "b_X";
            b_X.Size = new Size(50, 46);
            b_X.TabIndex = 33;
            b_X.Text = "x";
            b_X.UseVisualStyleBackColor = true;
            b_X.Click += button9_Click;
            // 
            // b_Comma
            // 
            b_Comma.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_Comma.FlatStyle = FlatStyle.Flat;
            b_Comma.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            b_Comma.ForeColor = SystemColors.Highlight;
            b_Comma.ImageAlign = ContentAlignment.TopCenter;
            b_Comma.Location = new Point(138, 176);
            b_Comma.Margin = new Padding(4);
            b_Comma.Name = "b_Comma";
            b_Comma.Size = new Size(50, 46);
            b_Comma.TabIndex = 32;
            b_Comma.Text = ",";
            b_Comma.UseVisualStyleBackColor = true;
            b_Comma.Click += button9_Click;
            // 
            // b_Plus
            // 
            b_Plus.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            b_Plus.FlatStyle = FlatStyle.Flat;
            b_Plus.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            b_Plus.ForeColor = SystemColors.Highlight;
            b_Plus.Location = new Point(305, 21);
            b_Plus.Margin = new Padding(4);
            b_Plus.Name = "b_Plus";
            b_Plus.Size = new Size(40, 41);
            b_Plus.TabIndex = 31;
            b_Plus.Text = "+";
            b_Plus.UseVisualStyleBackColor = true;
            b_Plus.Click += button9_Click;
            // 
            // b_Minus
            // 
            b_Minus.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            b_Minus.FlatStyle = FlatStyle.Flat;
            b_Minus.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            b_Minus.ForeColor = SystemColors.Highlight;
            b_Minus.Location = new Point(258, 21);
            b_Minus.Margin = new Padding(4);
            b_Minus.Name = "b_Minus";
            b_Minus.Size = new Size(40, 41);
            b_Minus.TabIndex = 30;
            b_Minus.Text = "-";
            b_Minus.UseVisualStyleBackColor = true;
            b_Minus.Click += button9_Click;
            // 
            // b_Multiply
            // 
            b_Multiply.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            b_Multiply.FlatStyle = FlatStyle.Flat;
            b_Multiply.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            b_Multiply.ForeColor = SystemColors.Highlight;
            b_Multiply.Location = new Point(210, 21);
            b_Multiply.Margin = new Padding(4);
            b_Multiply.Name = "b_Multiply";
            b_Multiply.Size = new Size(40, 41);
            b_Multiply.TabIndex = 29;
            b_Multiply.Text = "*";
            b_Multiply.UseVisualStyleBackColor = true;
            b_Multiply.Click += button9_Click;
            // 
            // b_Divide
            // 
            b_Divide.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            b_Divide.FlatStyle = FlatStyle.Flat;
            b_Divide.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b_Divide.ForeColor = SystemColors.Highlight;
            b_Divide.Location = new Point(162, 21);
            b_Divide.Margin = new Padding(4);
            b_Divide.Name = "b_Divide";
            b_Divide.Size = new Size(40, 41);
            b_Divide.TabIndex = 28;
            b_Divide.Text = "/";
            b_Divide.UseVisualStyleBackColor = true;
            b_Divide.Click += button9_Click;
            // 
            // b_RightBracket
            // 
            b_RightBracket.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            b_RightBracket.FlatStyle = FlatStyle.Flat;
            b_RightBracket.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b_RightBracket.ForeColor = SystemColors.Highlight;
            b_RightBracket.Location = new Point(115, 21);
            b_RightBracket.Margin = new Padding(4);
            b_RightBracket.Name = "b_RightBracket";
            b_RightBracket.Size = new Size(40, 41);
            b_RightBracket.TabIndex = 27;
            b_RightBracket.Text = ")";
            b_RightBracket.UseVisualStyleBackColor = true;
            b_RightBracket.Click += button9_Click;
            // 
            // b_LeftBracket
            // 
            b_LeftBracket.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            b_LeftBracket.FlatStyle = FlatStyle.Flat;
            b_LeftBracket.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b_LeftBracket.ForeColor = SystemColors.Highlight;
            b_LeftBracket.Location = new Point(68, 21);
            b_LeftBracket.Margin = new Padding(4);
            b_LeftBracket.Name = "b_LeftBracket";
            b_LeftBracket.Size = new Size(40, 41);
            b_LeftBracket.TabIndex = 26;
            b_LeftBracket.Text = "(";
            b_LeftBracket.UseVisualStyleBackColor = true;
            b_LeftBracket.Click += button9_Click;
            // 
            // b_Erase
            // 
            b_Erase.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            b_Erase.FlatStyle = FlatStyle.Flat;
            b_Erase.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            b_Erase.ForeColor = SystemColors.Highlight;
            b_Erase.Location = new Point(20, 21);
            b_Erase.Margin = new Padding(4);
            b_Erase.Name = "b_Erase";
            b_Erase.Size = new Size(40, 41);
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
            b_Back.Location = new Point(258, 176);
            b_Back.Margin = new Padding(4);
            b_Back.Name = "b_Back";
            b_Back.Size = new Size(50, 46);
            b_Back.TabIndex = 24;
            b_Back.Text = "⏴";
            b_Back.TextAlign = ContentAlignment.TopCenter;
            b_Back.UseVisualStyleBackColor = true;
            b_Back.Click += button19_Click;
            // 
            // Accuracy
            // 
            Accuracy.DecimalPlaces = 11;
            Accuracy.ForeColor = SystemColors.Highlight;
            Accuracy.Increment = new decimal(new int[] { 1, 0, 0, 655360 });
            Accuracy.Location = new Point(138, 309);
            Accuracy.Margin = new Padding(4);
            Accuracy.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            Accuracy.Minimum = new decimal(new int[] { 1, 0, 0, 655360 });
            Accuracy.Name = "Accuracy";
            Accuracy.Size = new Size(109, 31);
            Accuracy.TabIndex = 22;
            Accuracy.Value = new decimal(new int[] { 1, 0, 0, 196608 });
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = SystemColors.Highlight;
            textBox2.Location = new Point(49, 311);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(81, 24);
            textBox2.TabIndex = 21;
            textBox2.Text = "Delta:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.HighlightText;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = SystemColors.Highlight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "sin()", "cos()", "tan()", "cot()", "ln()", "pi", "e" });
            comboBox1.Location = new Point(49, 231);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(276, 29);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // b_6
            // 
            b_6.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_6.FlatStyle = FlatStyle.Flat;
            b_6.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_6.ForeColor = SystemColors.Highlight;
            b_6.Location = new Point(49, 124);
            b_6.Margin = new Padding(4);
            b_6.Name = "b_6";
            b_6.Size = new Size(50, 46);
            b_6.TabIndex = 10;
            b_6.Text = "6";
            b_6.UseVisualStyleBackColor = true;
            b_6.Click += button9_Click;
            // 
            // b_7
            // 
            b_7.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_7.FlatStyle = FlatStyle.Flat;
            b_7.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_7.ForeColor = SystemColors.Highlight;
            b_7.Location = new Point(105, 124);
            b_7.Margin = new Padding(4);
            b_7.Name = "b_7";
            b_7.Size = new Size(50, 46);
            b_7.TabIndex = 9;
            b_7.Text = "7";
            b_7.UseVisualStyleBackColor = true;
            b_7.Click += button9_Click;
            // 
            // b_5
            // 
            b_5.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_5.FlatStyle = FlatStyle.Flat;
            b_5.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_5.ForeColor = SystemColors.Highlight;
            b_5.Location = new Point(279, 70);
            b_5.Margin = new Padding(4);
            b_5.Name = "b_5";
            b_5.Size = new Size(50, 46);
            b_5.TabIndex = 8;
            b_5.Text = "5";
            b_5.UseVisualStyleBackColor = true;
            b_5.Click += button9_Click;
            // 
            // b_0
            // 
            b_0.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_0.FlatStyle = FlatStyle.Flat;
            b_0.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_0.ForeColor = SystemColors.Highlight;
            b_0.Location = new Point(279, 124);
            b_0.Margin = new Padding(4);
            b_0.Name = "b_0";
            b_0.Size = new Size(50, 46);
            b_0.TabIndex = 7;
            b_0.Text = "0";
            b_0.UseVisualStyleBackColor = true;
            b_0.Click += button9_Click;
            // 
            // b_9
            // 
            b_9.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_9.FlatStyle = FlatStyle.Flat;
            b_9.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_9.ForeColor = SystemColors.Highlight;
            b_9.Location = new Point(220, 124);
            b_9.Margin = new Padding(4);
            b_9.Name = "b_9";
            b_9.Size = new Size(50, 46);
            b_9.TabIndex = 6;
            b_9.Text = "9";
            b_9.UseVisualStyleBackColor = true;
            b_9.Click += button9_Click;
            // 
            // b_8
            // 
            b_8.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_8.FlatStyle = FlatStyle.Flat;
            b_8.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_8.ForeColor = SystemColors.Highlight;
            b_8.Location = new Point(161, 124);
            b_8.Margin = new Padding(4);
            b_8.Name = "b_8";
            b_8.Size = new Size(50, 46);
            b_8.TabIndex = 5;
            b_8.Text = "8";
            b_8.UseVisualStyleBackColor = true;
            b_8.Click += button9_Click;
            // 
            // b_4
            // 
            b_4.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_4.FlatStyle = FlatStyle.Flat;
            b_4.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_4.ForeColor = SystemColors.Highlight;
            b_4.Location = new Point(220, 70);
            b_4.Margin = new Padding(4);
            b_4.Name = "b_4";
            b_4.Size = new Size(50, 46);
            b_4.TabIndex = 4;
            b_4.Text = "4";
            b_4.UseVisualStyleBackColor = true;
            b_4.Click += button9_Click;
            // 
            // b_3
            // 
            b_3.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_3.FlatStyle = FlatStyle.Flat;
            b_3.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_3.ForeColor = SystemColors.Highlight;
            b_3.Location = new Point(161, 70);
            b_3.Margin = new Padding(4);
            b_3.Name = "b_3";
            b_3.Size = new Size(50, 46);
            b_3.TabIndex = 3;
            b_3.Text = "3";
            b_3.UseVisualStyleBackColor = true;
            b_3.Click += button9_Click;
            // 
            // b_2
            // 
            b_2.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_2.FlatStyle = FlatStyle.Flat;
            b_2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_2.ForeColor = SystemColors.Highlight;
            b_2.Location = new Point(105, 70);
            b_2.Margin = new Padding(4);
            b_2.Name = "b_2";
            b_2.Size = new Size(50, 46);
            b_2.TabIndex = 2;
            b_2.Text = "2";
            b_2.UseVisualStyleBackColor = true;
            b_2.Click += button9_Click;
            // 
            // b_1
            // 
            b_1.FlatAppearance.BorderColor = SystemColors.Highlight;
            b_1.FlatStyle = FlatStyle.Flat;
            b_1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_1.ForeColor = SystemColors.Highlight;
            b_1.Location = new Point(50, 70);
            b_1.Margin = new Padding(4);
            b_1.Name = "b_1";
            b_1.Size = new Size(50, 46);
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
            b_Count.Location = new Point(2, 364);
            b_Count.Margin = new Padding(4);
            b_Count.Name = "b_Count";
            b_Count.Size = new Size(365, 62);
            b_Count.TabIndex = 0;
            b_Count.Text = "Count In Mind";
            b_Count.UseVisualStyleBackColor = false;
            b_Count.Click += Count_Click;
            // 
            // button22
            // 
            button22.Location = new Point(0, 0);
            button22.Margin = new Padding(4);
            button22.Name = "button22";
            button22.Size = new Size(94, 29);
            button22.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(l_time);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Formula);
            panel2.Controls.Add(UpperIntegralRange);
            panel2.Controls.Add(LowerIntegralRange);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 2);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 160);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint_1;
            // 
            // l_time
            // 
            l_time.AutoSize = true;
            l_time.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_time.ForeColor = SystemColors.ButtonHighlight;
            l_time.Location = new Point(137, 118);
            l_time.Name = "l_time";
            l_time.Size = new Size(0, 21);
            l_time.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(324, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 30);
            label2.TabIndex = 4;
            label2.Text = "dx";
            // 
            // Formula
            // 
            Formula.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Formula.ForeColor = SystemColors.Highlight;
            Formula.Location = new Point(126, 59);
            Formula.Margin = new Padding(4);
            Formula.Name = "Formula";
            Formula.Size = new Size(194, 35);
            Formula.TabIndex = 3;
            // 
            // UpperIntegralRange
            // 
            UpperIntegralRange.BorderStyle = BorderStyle.None;
            UpperIntegralRange.DecimalPlaces = 1;
            UpperIntegralRange.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UpperIntegralRange.ForeColor = SystemColors.Highlight;
            UpperIntegralRange.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            UpperIntegralRange.Location = new Point(15, 4);
            UpperIntegralRange.Margin = new Padding(4);
            UpperIntegralRange.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            UpperIntegralRange.Name = "UpperIntegralRange";
            UpperIntegralRange.Size = new Size(109, 24);
            UpperIntegralRange.TabIndex = 2;
            UpperIntegralRange.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // LowerIntegralRange
            // 
            LowerIntegralRange.BorderStyle = BorderStyle.None;
            LowerIntegralRange.DecimalPlaces = 1;
            LowerIntegralRange.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LowerIntegralRange.ForeColor = SystemColors.Highlight;
            LowerIntegralRange.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            LowerIntegralRange.Location = new Point(15, 118);
            LowerIntegralRange.Margin = new Padding(4);
            LowerIntegralRange.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            LowerIntegralRange.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            LowerIntegralRange.Name = "LowerIntegralRange";
            LowerIntegralRange.Size = new Size(109, 24);
            LowerIntegralRange.TabIndex = 1;
            LowerIntegralRange.Value = new decimal(new int[] { 10, 0, 0, int.MinValue });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(78, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 102);
            label1.TabIndex = 1;
            label1.Text = "∫";
            // 
            // GraphPanel
            // 
            GraphPanel.Location = new Point(375, 15);
            GraphPanel.Margin = new Padding(4);
            GraphPanel.Name = "GraphPanel";
            GraphPanel.Size = new Size(715, 604);
            GraphPanel.TabIndex = 2;
            GraphPanel.MouseMove += GraphPanel_MouseMove;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 99F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 89F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(YMax, 3, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(YMin, 1, 0);
            tableLayoutPanel1.Controls.Add(l_x, 4, 0);
            tableLayoutPanel1.Controls.Add(l_y, 5, 0);
            tableLayoutPanel1.Location = new Point(375, 626);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(715, 51);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(5, 1);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 49);
            label3.TabIndex = 0;
            label3.Text = "Y Min";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // YMax
            // 
            YMax.Location = new Point(392, 5);
            YMax.Margin = new Padding(4);
            YMax.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            YMax.Name = "YMax";
            YMax.Size = new Size(127, 31);
            YMax.TabIndex = 3;
            YMax.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(273, 1);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 49);
            label4.TabIndex = 1;
            label4.Text = "Y Max";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // YMin
            // 
            YMin.Location = new Point(130, 5);
            YMin.Margin = new Padding(4);
            YMin.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            YMin.Name = "YMin";
            YMin.Size = new Size(130, 31);
            YMin.TabIndex = 2;
            // 
            // l_x
            // 
            l_x.AutoSize = true;
            l_x.Location = new Point(528, 1);
            l_x.Margin = new Padding(4, 0, 4, 0);
            l_x.Name = "l_x";
            l_x.Size = new Size(0, 25);
            l_x.TabIndex = 4;
            // 
            // l_y
            // 
            l_y.AutoSize = true;
            l_y.Location = new Point(628, 1);
            l_y.Margin = new Padding(4, 0, 4, 0);
            l_y.Name = "l_y";
            l_y.Size = new Size(0, 25);
            l_y.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.98592F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.01408F));
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(l_Result, 1, 0);
            tableLayoutPanel2.Location = new Point(10, 170);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(355, 56);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(5, 1);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 54);
            label5.TabIndex = 0;
            label5.Text = "Result:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_Result
            // 
            l_Result.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            l_Result.AutoSize = true;
            l_Result.Location = new Point(115, 1);
            l_Result.Margin = new Padding(4, 0, 4, 0);
            l_Result.Name = "l_Result";
            l_Result.Size = new Size(235, 54);
            l_Result.TabIndex = 1;
            l_Result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1100, 666);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(GraphPanel);
            Controls.Add(panel2);
            Controls.Add(button22);
            Controls.Add(panel1);
            Margin = new Padding(4);
            MaximumSize = new Size(1122, 722);
            MinimumSize = new Size(1122, 722);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Accuracy).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UpperIntegralRange).EndInit();
            ((System.ComponentModel.ISupportInitialize)LowerIntegralRange).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)YMin).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private Button button24;
        private Button b_Power;
        private Button button26;
        private Panel GraphPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private NumericUpDown YMax;
        private Label label4;
        private NumericUpDown YMin;
        private Label l_x;
        private Label l_y;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private Label l_Result;
        private Label label6;
        private Label l_time;
    }
}