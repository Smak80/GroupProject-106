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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button26 = new System.Windows.Forms.Button();
            this.b_Power = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.b_ChangeSign = new System.Windows.Forms.Button();
            this.b_X = new System.Windows.Forms.Button();
            this.b_Comma = new System.Windows.Forms.Button();
            this.b_Plus = new System.Windows.Forms.Button();
            this.b_Minus = new System.Windows.Forms.Button();
            this.b_Multiply = new System.Windows.Forms.Button();
            this.b_Divide = new System.Windows.Forms.Button();
            this.b_RightBracket = new System.Windows.Forms.Button();
            this.b_LeftBracket = new System.Windows.Forms.Button();
            this.b_Erase = new System.Windows.Forms.Button();
            this.b_Back = new System.Windows.Forms.Button();
            this.Accuracy = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.b_6 = new System.Windows.Forms.Button();
            this.b_7 = new System.Windows.Forms.Button();
            this.b_5 = new System.Windows.Forms.Button();
            this.b_0 = new System.Windows.Forms.Button();
            this.b_9 = new System.Windows.Forms.Button();
            this.b_8 = new System.Windows.Forms.Button();
            this.b_4 = new System.Windows.Forms.Button();
            this.b_3 = new System.Windows.Forms.Button();
            this.b_2 = new System.Windows.Forms.Button();
            this.b_1 = new System.Windows.Forms.Button();
            this.b_Count = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Formula = new System.Windows.Forms.TextBox();
            this.UpperIntegralRange = new System.Windows.Forms.NumericUpDown();
            this.LowerIntegralRange = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accuracy)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpperIntegralRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerIntegralRange)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button26);
            this.panel1.Controls.Add(this.b_Power);
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.b_ChangeSign);
            this.panel1.Controls.Add(this.b_X);
            this.panel1.Controls.Add(this.b_Comma);
            this.panel1.Controls.Add(this.b_Plus);
            this.panel1.Controls.Add(this.b_Minus);
            this.panel1.Controls.Add(this.b_Multiply);
            this.panel1.Controls.Add(this.b_Divide);
            this.panel1.Controls.Add(this.b_RightBracket);
            this.panel1.Controls.Add(this.b_LeftBracket);
            this.panel1.Controls.Add(this.b_Erase);
            this.panel1.Controls.Add(this.b_Back);
            this.panel1.Controls.Add(this.Accuracy);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.b_6);
            this.panel1.Controls.Add(this.b_7);
            this.panel1.Controls.Add(this.b_5);
            this.panel1.Controls.Add(this.b_0);
            this.panel1.Controls.Add(this.b_9);
            this.panel1.Controls.Add(this.b_8);
            this.panel1.Controls.Add(this.b_4);
            this.panel1.Controls.Add(this.b_3);
            this.panel1.Controls.Add(this.b_2);
            this.panel1.Controls.Add(this.b_1);
            this.panel1.Controls.Add(this.b_Count);
            this.panel1.Location = new System.Drawing.Point(0, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 347);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.SystemColors.Window;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button26.Location = new System.Drawing.Point(35, 227);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(158, 27);
            this.button26.TabIndex = 38;
            this.button26.Text = "Const";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // b_Power
            // 
            this.b_Power.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_Power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Power.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_Power.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_Power.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_Power.Location = new System.Drawing.Point(35, 143);
            this.b_Power.Name = "b_Power";
            this.b_Power.Size = new System.Drawing.Size(40, 37);
            this.b_Power.TabIndex = 37;
            this.b_Power.Text = "^";
            this.b_Power.UseVisualStyleBackColor = true;
            this.b_Power.Click += new System.EventHandler(this.button25_Click);
            // 
            // button24
            // 
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button24.Location = new System.Drawing.Point(198, 227);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(59, 58);
            this.button24.TabIndex = 36;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // b_ChangeSign
            // 
            this.b_ChangeSign.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_ChangeSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ChangeSign.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_ChangeSign.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_ChangeSign.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_ChangeSign.Location = new System.Drawing.Point(80, 142);
            this.b_ChangeSign.Name = "b_ChangeSign";
            this.b_ChangeSign.Size = new System.Drawing.Size(40, 37);
            this.b_ChangeSign.TabIndex = 35;
            this.b_ChangeSign.Text = "+/-";
            this.b_ChangeSign.UseVisualStyleBackColor = true;
            this.b_ChangeSign.Click += new System.EventHandler(this.button23_Click);
            // 
            // b_X
            // 
            this.b_X.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_X.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_X.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_X.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_X.Location = new System.Drawing.Point(172, 142);
            this.b_X.Name = "b_X";
            this.b_X.Size = new System.Drawing.Size(40, 37);
            this.b_X.TabIndex = 33;
            this.b_X.Text = "x";
            this.b_X.UseVisualStyleBackColor = true;
            this.b_X.Click += new System.EventHandler(this.button21_Click);
            // 
            // b_Comma
            // 
            this.b_Comma.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_Comma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Comma.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_Comma.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_Comma.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_Comma.Location = new System.Drawing.Point(125, 142);
            this.b_Comma.Name = "b_Comma";
            this.b_Comma.Size = new System.Drawing.Size(40, 37);
            this.b_Comma.TabIndex = 32;
            this.b_Comma.Text = ",";
            this.b_Comma.UseVisualStyleBackColor = true;
            this.b_Comma.Click += new System.EventHandler(this.button7_Click);
            // 
            // b_Plus
            // 
            this.b_Plus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Plus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_Plus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_Plus.Location = new System.Drawing.Point(239, 3);
            this.b_Plus.Name = "b_Plus";
            this.b_Plus.Size = new System.Drawing.Size(32, 33);
            this.b_Plus.TabIndex = 31;
            this.b_Plus.Text = "+";
            this.b_Plus.UseVisualStyleBackColor = true;
            this.b_Plus.Click += new System.EventHandler(this.button6_Click);
            // 
            // b_Minus
            // 
            this.b_Minus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Minus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_Minus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_Minus.Location = new System.Drawing.Point(201, 3);
            this.b_Minus.Name = "b_Minus";
            this.b_Minus.Size = new System.Drawing.Size(32, 33);
            this.b_Minus.TabIndex = 30;
            this.b_Minus.Text = "-";
            this.b_Minus.UseVisualStyleBackColor = true;
            this.b_Minus.Click += new System.EventHandler(this.button6_Click);
            // 
            // b_Multiply
            // 
            this.b_Multiply.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Multiply.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_Multiply.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_Multiply.Location = new System.Drawing.Point(163, 3);
            this.b_Multiply.Name = "b_Multiply";
            this.b_Multiply.Size = new System.Drawing.Size(32, 33);
            this.b_Multiply.TabIndex = 29;
            this.b_Multiply.Text = "*";
            this.b_Multiply.UseVisualStyleBackColor = true;
            this.b_Multiply.Click += new System.EventHandler(this.button6_Click);
            // 
            // b_Divide
            // 
            this.b_Divide.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Divide.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_Divide.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_Divide.Location = new System.Drawing.Point(125, 3);
            this.b_Divide.Name = "b_Divide";
            this.b_Divide.Size = new System.Drawing.Size(32, 33);
            this.b_Divide.TabIndex = 28;
            this.b_Divide.Text = "/";
            this.b_Divide.UseVisualStyleBackColor = true;
            this.b_Divide.Click += new System.EventHandler(this.button6_Click);
            // 
            // b_RightBracket
            // 
            this.b_RightBracket.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_RightBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_RightBracket.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_RightBracket.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_RightBracket.Location = new System.Drawing.Point(87, 3);
            this.b_RightBracket.Name = "b_RightBracket";
            this.b_RightBracket.Size = new System.Drawing.Size(32, 33);
            this.b_RightBracket.TabIndex = 27;
            this.b_RightBracket.Text = ")";
            this.b_RightBracket.UseVisualStyleBackColor = true;
            this.b_RightBracket.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_LeftBracket
            // 
            this.b_LeftBracket.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_LeftBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_LeftBracket.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_LeftBracket.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_LeftBracket.Location = new System.Drawing.Point(49, 3);
            this.b_LeftBracket.Name = "b_LeftBracket";
            this.b_LeftBracket.Size = new System.Drawing.Size(32, 33);
            this.b_LeftBracket.TabIndex = 26;
            this.b_LeftBracket.Text = "(";
            this.b_LeftBracket.UseVisualStyleBackColor = true;
            this.b_LeftBracket.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_Erase
            // 
            this.b_Erase.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_Erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Erase.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_Erase.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_Erase.Location = new System.Drawing.Point(11, 3);
            this.b_Erase.Name = "b_Erase";
            this.b_Erase.Size = new System.Drawing.Size(32, 33);
            this.b_Erase.TabIndex = 25;
            this.b_Erase.Text = "C";
            this.b_Erase.UseVisualStyleBackColor = true;
            this.b_Erase.Click += new System.EventHandler(this.button20_Click);
            // 
            // b_Back
            // 
            this.b_Back.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Back.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_Back.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_Back.Location = new System.Drawing.Point(219, 142);
            this.b_Back.Name = "b_Back";
            this.b_Back.Size = new System.Drawing.Size(40, 37);
            this.b_Back.TabIndex = 24;
            this.b_Back.Text = "⏴";
            this.b_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_Back.UseVisualStyleBackColor = true;
            this.b_Back.Click += new System.EventHandler(this.button19_Click);
            // 
            // Accuracy
            // 
            this.Accuracy.DecimalPlaces = 3;
            this.Accuracy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Accuracy.Location = new System.Drawing.Point(106, 258);
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.Size = new System.Drawing.Size(87, 27);
            this.Accuracy.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox2.Location = new System.Drawing.Point(35, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 20);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Accuracy:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sin()",
            "cos()",
            "tg()",
            "ctg()",
            "ln()",
            "log(x,y)",
            "pi",
            "e",
            "const"});
            this.comboBox1.Location = new System.Drawing.Point(35, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Functions";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // b_6
            // 
            this.b_6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_6.Location = new System.Drawing.Point(35, 100);
            this.b_6.Name = "b_6";
            this.b_6.Size = new System.Drawing.Size(40, 37);
            this.b_6.TabIndex = 10;
            this.b_6.Text = "6";
            this.b_6.UseVisualStyleBackColor = true;
            this.b_6.Click += new System.EventHandler(this.button18_Click);
            // 
            // b_7
            // 
            this.b_7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_7.Location = new System.Drawing.Point(80, 100);
            this.b_7.Name = "b_7";
            this.b_7.Size = new System.Drawing.Size(40, 37);
            this.b_7.TabIndex = 9;
            this.b_7.Text = "7";
            this.b_7.UseVisualStyleBackColor = true;
            this.b_7.Click += new System.EventHandler(this.button17_Click);
            // 
            // b_5
            // 
            this.b_5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_5.Location = new System.Drawing.Point(219, 57);
            this.b_5.Name = "b_5";
            this.b_5.Size = new System.Drawing.Size(40, 37);
            this.b_5.TabIndex = 8;
            this.b_5.Text = "5";
            this.b_5.UseVisualStyleBackColor = true;
            this.b_5.Click += new System.EventHandler(this.button16_Click);
            // 
            // b_0
            // 
            this.b_0.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_0.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_0.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_0.Location = new System.Drawing.Point(219, 100);
            this.b_0.Name = "b_0";
            this.b_0.Size = new System.Drawing.Size(40, 37);
            this.b_0.TabIndex = 7;
            this.b_0.Text = "0";
            this.b_0.UseVisualStyleBackColor = true;
            this.b_0.Click += new System.EventHandler(this.button15_Click);
            // 
            // b_9
            // 
            this.b_9.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_9.Location = new System.Drawing.Point(172, 100);
            this.b_9.Name = "b_9";
            this.b_9.Size = new System.Drawing.Size(40, 37);
            this.b_9.TabIndex = 6;
            this.b_9.Text = "9";
            this.b_9.UseVisualStyleBackColor = true;
            this.b_9.Click += new System.EventHandler(this.button14_Click);
            // 
            // b_8
            // 
            this.b_8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_8.Location = new System.Drawing.Point(125, 100);
            this.b_8.Name = "b_8";
            this.b_8.Size = new System.Drawing.Size(40, 37);
            this.b_8.TabIndex = 5;
            this.b_8.Text = "8";
            this.b_8.UseVisualStyleBackColor = true;
            this.b_8.Click += new System.EventHandler(this.button13_Click);
            // 
            // b_4
            // 
            this.b_4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_4.Location = new System.Drawing.Point(172, 57);
            this.b_4.Name = "b_4";
            this.b_4.Size = new System.Drawing.Size(40, 37);
            this.b_4.TabIndex = 4;
            this.b_4.Text = "4";
            this.b_4.UseVisualStyleBackColor = true;
            this.b_4.Click += new System.EventHandler(this.button12_Click);
            // 
            // b_3
            // 
            this.b_3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_3.Location = new System.Drawing.Point(125, 57);
            this.b_3.Name = "b_3";
            this.b_3.Size = new System.Drawing.Size(40, 37);
            this.b_3.TabIndex = 3;
            this.b_3.Text = "3";
            this.b_3.UseVisualStyleBackColor = true;
            this.b_3.Click += new System.EventHandler(this.button11_Click);
            // 
            // b_2
            // 
            this.b_2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_2.Location = new System.Drawing.Point(80, 57);
            this.b_2.Name = "b_2";
            this.b_2.Size = new System.Drawing.Size(40, 37);
            this.b_2.TabIndex = 2;
            this.b_2.Text = "2";
            this.b_2.UseVisualStyleBackColor = true;
            this.b_2.Click += new System.EventHandler(this.button10_Click);
            // 
            // b_1
            // 
            this.b_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.b_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_1.Location = new System.Drawing.Point(35, 57);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(40, 37);
            this.b_1.TabIndex = 1;
            this.b_1.Text = "1";
            this.b_1.UseVisualStyleBackColor = true;
            this.b_1.Click += new System.EventHandler(this.button9_Click);
            // 
            // b_Count
            // 
            this.b_Count.BackColor = System.Drawing.SystemColors.Highlight;
            this.b_Count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_Count.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_Count.Location = new System.Drawing.Point(0, 304);
            this.b_Count.Name = "b_Count";
            this.b_Count.Size = new System.Drawing.Size(292, 43);
            this.b_Count.TabIndex = 0;
            this.b_Count.Text = "Count In Mind";
            this.b_Count.UseVisualStyleBackColor = false;
            this.b_Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(0, 0);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Formula);
            this.panel2.Controls.Add(this.UpperIntegralRange);
            this.panel2.Controls.Add(this.LowerIntegralRange);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 97);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(259, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "dx";
            // 
            // Formula
            // 
            this.Formula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Formula.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Formula.Location = new System.Drawing.Point(101, 28);
            this.Formula.Name = "Formula";
            this.Formula.Size = new System.Drawing.Size(156, 30);
            this.Formula.TabIndex = 3;
            this.Formula.TextChanged += new System.EventHandler(this.Formula_TextChanged);
            // 
            // UpperIntegralRange
            // 
            this.UpperIntegralRange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpperIntegralRange.DecimalPlaces = 1;
            this.UpperIntegralRange.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpperIntegralRange.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UpperIntegralRange.Location = new System.Drawing.Point(12, 8);
            this.UpperIntegralRange.Name = "UpperIntegralRange";
            this.UpperIntegralRange.Size = new System.Drawing.Size(47, 21);
            this.UpperIntegralRange.TabIndex = 2;
            this.UpperIntegralRange.ValueChanged += new System.EventHandler(this.UpperIntegralRange_ValueChanged);
            // 
            // LowerIntegralRange
            // 
            this.LowerIntegralRange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LowerIntegralRange.DecimalPlaces = 1;
            this.LowerIntegralRange.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LowerIntegralRange.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LowerIntegralRange.Location = new System.Drawing.Point(12, 57);
            this.LowerIntegralRange.Name = "LowerIntegralRange";
            this.LowerIntegralRange.Size = new System.Drawing.Size(47, 21);
            this.LowerIntegralRange.TabIndex = 1;
            this.LowerIntegralRange.ValueChanged += new System.EventHandler(this.LowerIntegralRange_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "∫";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accuracy)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpperIntegralRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerIntegralRange)).EndInit();
            this.ResumeLayout(false);

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