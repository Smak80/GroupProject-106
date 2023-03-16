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

namespace GroupProject_106
{
    public partial class Form1 : Form
    {
        public string name = "";
        private int a;
        private int b;
        private bool flag = false;
        private Painter g;

        ListBox listbox10 = new ListBox();
        List<string> inputs = new List<string>();
        //BindingList<Inputs> input = new BindingList<Inputs>();
        //BindingList<Const> constants = new BindingList<Const>();
        BindingList<ConstantValues> constants = new();

        public Form1(string expression)
        {
            InitializeComponent();
            Formula.Text += expression;
            g= new Painter(GraphPanel.CreateGraphics());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1.BackColor = Color.White;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //panel2.BackColor = Color.Highlight;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //panel3.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            Formula.Text = Formula.Text + B.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button One = (Button)sender;
            Formula.Text = Formula.Text + One.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button Two = (Button)sender;
            Formula.Text = Formula.Text + Two.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            Formula.Text = Formula.Text + Three.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            Formula.Text = Formula.Text + Three.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            Formula.Text = Formula.Text + Three.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            Formula.Text = Formula.Text + Three.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            Formula.Text = Formula.Text + Three.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            Formula.Text = Formula.Text + Three.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            Formula.Text = Formula.Text + Three.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            Formula.Text = Formula.Text + Three.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Formula.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            Formula.Text = Formula.Text + Three.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            Formula.Text = Formula.Text + Three.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Formula.Text = Formula.Text + "(-";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            Formula.Text = Formula.Text + Three.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string[] arr = Formula.Lines.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Remove(arr.Length, 1);
            }
            Formula.Lines = arr;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            Formula.Text = Formula.Text + Three.Text;
        }

        private void UpperIntegralRange_ValueChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(UpperIntegralRange.Value);
        }

        private void LowerIntegralRange_ValueChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt32(Accuracy.Value);
        }
        private void Count_Click(object sender, EventArgs e)
        {
            if (Formula.Lines != null)
            {
                inputs.Add(Formula.Text);
            }

            InputDataCheckAndCorrect check = new InputDataCheckAndCorrect(Formula.Text ?? "" , listbox10);
            if (check.InputDataDiagnostic())
            {
                // Graph inisiallise
                g.initCoord((double)LowerIntegralRange.Value, (double)UpperIntegralRange.Value, (double)YMax.Value, (double)YMin.Value, (double)Accuracy.Value);
                g.PaintCordPlane();


                // izmenenaya stroka dlya adeli 
                string expression = check.ExprChangeForParsing();
                Formula.Text = expression;
                /*
                 
                 zdes proishodit parsing
 
                 i schet integrala
                 
                 */


                //Formula.Clear();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //if (flag == false) richTextBox1.Visible = false;
            //else if (flag == true) richTextBox1.Show();
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
