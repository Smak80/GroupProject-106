using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1;
using static System.Windows.Forms.DataFormats;
using System.Linq;
using System.Reflection.Emit;
using System.Diagnostics;

namespace GroupProject_106
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new();
        public string name = "";
        private int a;
        private int b;
        private bool flag = false;
        public Painter g;
        object drawlocker = new();

        ListBox listbox10 = new ListBox();
        List<string> inputs = new List<string>();
        //BindingList<Inputs> input = new BindingList<Inputs>();
        //BindingList<Const> constants = new BindingList<Const>();
        BindingList<ConstantValues> constants = new();

        public Form1(string expression)
        {
            InitializeComponent();
            Formula.Text += expression;
            g = new Painter(GraphPanel.CreateGraphics());

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            Formula.Text = Formula.Text + B.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Formula.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Formula.Text = Formula.Text + "(-";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Formula.Text != "") Formula.Text = Formula.Text.Remove(Formula.Text.Length - 1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = comboBox1.SelectedItem;
            //char[] selectedState = new char[10];
            //selectedState = selectedItem.ToString();
            switch (selectedItem.ToString())
            {
                case "cos()":
                    Formula.Text = Formula.Text + "cos(";
                    break;
                case "sin()":
                    Formula.Text = Formula.Text + "sin(";
                    break;
                case "tan()":
                    Formula.Text = Formula.Text + "tan(";
                    break;
                case "cot()":
                    Formula.Text = Formula.Text + "cot(";
                    break;
                case "ln()":
                    Formula.Text = Formula.Text + "ln(";
                    break;
                case "pi":
                    Formula.Text = Formula.Text + "pi";
                    break;
                case "e":
                    Formula.Text = Formula.Text + "e";
                    break;
                case "const":
                    Formula.Text = Formula.Text + "const";
                    break;
            }
        }


        private void UpperIntegralRange_ValueChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(UpperIntegralRange.Value);
        }

        private void LowerIntegralRange_ValueChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt32(Accuracy.Value);
        }

        private int Order(double num)
        {
            if (num > 0)
            {
                int order = 0;
                while (num < 1)
                {
                    order++;
                    num *= 10;
                }
                return order;
            }
            return -1;
        }

        public void FinishFunc()
        {
            if (InvokeRequired) l_Result.Invoke(FinishFunc);
            else
            {
                sw.Stop();
                l_Result.Text += double.Round(Consumer.Integral, Order((double)Accuracy.Value)).ToString();
                l_timeResult.Text = sw.ElapsedMilliseconds + "ms";
                LowerIntegralRange.Enabled = true;
                UpperIntegralRange.Enabled = true;
                Accuracy.Enabled = true;
                Formula.Enabled = true;
                comboBox1.Enabled = true;
                b_0.Enabled = true;
                b_1.Enabled = true;
                b_2.Enabled = true;
                b_3.Enabled = true;
                b_4.Enabled = true;
                b_5.Enabled = true;
                b_6.Enabled = true;
                b_7.Enabled = true;
                b_8.Enabled = true;
                b_9.Enabled = true;
                b_Back.Enabled = true;
                b_Comma.Enabled = true;
                b_Count.Enabled = true;
                b_Divide.Enabled = true;
                b_Erase.Enabled = true;
                b_LeftBracket.Enabled = true;
                b_Minus.Enabled = true;
                b_Multiply.Enabled = true;
                b_Plus.Enabled = true;
                b_Power.Enabled = true;
                b_RightBracket.Enabled = true;
                b_X.Enabled = true;
            }
        }

        public void DrawFunc(List<double[]> coordinates)
        {
            if (InvokeRequired)
            {
                Invoke(DrawFunc, coordinates);
            }
            else
            {
                lock (drawlocker)
                {
                    foreach (var coord in coordinates)
                    {
                        g.PaintGraph(coord[0], coord[1]);
                    }
                }
            }
        }

        private void Count_Click(object sender, EventArgs e)
        {
            l_Result.Text = "";
            if (Formula.Lines != null)
            {
                inputs.Add(Formula.Text);
            }

            InputDataCheckAndCorrect check = new InputDataCheckAndCorrect(Formula.Text ?? "", listbox10, (double)LowerIntegralRange.Value, (double)UpperIntegralRange.Value);
            if (check.InputDataDiagnostic())
            {
                // Graph initialization
                g.initCoord((double)LowerIntegralRange.Value,(double)UpperIntegralRange.Value,(double)YMax.Value, (double)YMin.Value, (double)Accuracy.Value);
                g.PaintCordPlane();

                // izmenenaya stroka dlya adeli 
                string expression = check.ExprChangeForParsing();
                Parsing parse = new Parsing(expression);
                List<string> parsingList = parse.StartParse();
                ExpressionTree tree = new ExpressionTree(parsingList);
                double deltha = (double)Accuracy.Value;
                double start = (double)LowerIntegralRange.Value;
                double end = (double)UpperIntegralRange.Value;
                l_timeResult.Text = "";
                LowerIntegralRange.Enabled = false;
                UpperIntegralRange.Enabled = false;
                Accuracy.Enabled = false;
                Formula.Enabled = false;
                comboBox1.Enabled = false;
                b_0.Enabled = false;
                b_1.Enabled = false;
                b_2.Enabled = false;
                b_3.Enabled = false;
                b_4.Enabled = false;
                b_5.Enabled = false;
                b_6.Enabled = false;
                b_7.Enabled = false;
                b_8.Enabled = false;
                b_9.Enabled = false;
                b_Back.Enabled = false;
                b_Comma.Enabled = false;
                b_Count.Enabled = false;
                b_Divide.Enabled = false;
                b_Erase.Enabled = false;
                b_LeftBracket.Enabled = false;
                b_Minus.Enabled = false;
                b_Multiply.Enabled = false;
                b_Plus.Enabled = false;
                b_Power.Enabled = false;
                b_RightBracket.Enabled = false;
                b_X.Enabled = false;

                sw.Reset();
                sw.Start();
                Producer p1 = new Producer(start, end, deltha, tree);
                Consumer c = new Consumer();
                p1.Draw += DrawFunc;
                p1.Finish += FinishFunc;
                c.Start(0.001);
                p1.Start();


                //Formula.Clear();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            var History = new History();
            History.inputs = inputs;

            History.ShowDialog();
            Formula.Text = History.name;
            History.Dispose();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Formula.Text = Formula.Text + "^(";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            var frm2 = new Const(constants, flag);
            flag = true;

            frm2.ShowDialog();
            listbox10.Items.Clear();
            foreach (var constantValue in constants)
            {
                listbox10.Items.Add(constantValue.ToString()); //ñâÿçûâàíèå äàííûõ
            }
            //Const.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GraphPanel_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (e.X < g.X) l_x.Text = (0 - e.X / g.multiplierX).ToString();
            if (e.X > g.X) l_x.Text = (e.X / g.multiplierX).ToString();
            if (e.Y < g.Y) l_y.Text = (0 + e.Y / g.multiplierX).ToString();
            if (e.Y > g.Y) l_y.Text = (0-e.Y / g.multiplierX).ToString();
            // l_x.Text = (g.X + (double)(e.X) / g.multiplierX).ToString();
            //l_y.Text = (g.Y - (e.Y < 0 ? 0 : e.Y / g.multiplierY)).ToString();*/
        }
    }
}
