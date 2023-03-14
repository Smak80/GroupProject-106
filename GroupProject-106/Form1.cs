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

namespace GroupProject_106
{
    public partial class Form1 : Form
    {
        private int a;
        private int b;
        //public int k;
        List<string> inputs = new List<string>();
        //BindingList<Inputs> input = new BindingList<Inputs>();
        //BindingList<Const> constants = new BindingList<Const>();
        BindingList<ConstantValues> constants = new();
        bool flag = true;
        //inputs[0] = "0";
        //var History = new History(inputs);
        public Form1(string expression)
        {
            InitializeComponent();
            Formula.Text += expression;
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

        private void Formula_TextChanged(object sender, EventArgs e)
        {

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
                case "tg()":
                    Formula.Text = Formula.Text + "tg(";
                    break;
                case "ctg()":
                    Formula.Text = Formula.Text + "ctg(";
                    break;
                case "ln()":
                    Formula.Text = Formula.Text + "ln(";
                    break;
                case "log(x,y)":
                    Formula.Text = Formula.Text + "log(";
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

        /*private void button22_Click(object sender, EventArgs e)
        {
            
        }
        */
        private void Count_Click(object sender, EventArgs e)
        {
            if (Formula.Lines != null)
            {
                inputs.Add(Formula.Text);
            }

            CheckForSyntax check = new CheckForSyntax(Formula.Text);
            if (check.ExpressionDiagnostic())
            {
                // izmenenaya stroka dlya adeli 
                string expression = check.ExprAdjustment();


                /*
                 
                 zdes proishodit parsing
 
                 i schet integrala
                 
                 */


                Formula.Clear();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //if (flag == false) richTextBox1.Visible = false;
            //else if (flag == true) richTextBox1.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //inputs.Add(new());
            //inputs.Add(new() {Value = ""});
            var History = new History();
            History.inputs = inputs;
            //int m = History.k;
            //History.textBox1 = textBox1;
            /*DataTable table = new DataTable();
            table.Rows.Add(textBox1.Text);
            dataGridView1.DataSource = table;*/
            //inputs.Add(textBox1.Text);
            //History.ShowDialog();
            /*ListBox listBox3 = new ListBox();
            listBox3.Items.Clear();
            foreach (var a in inputs) {
                listBox3.Items.Add(a); //ñâÿçûâàíèå äàííûõ
            }
            textBox1.Text = k;*/
            /*if (k > 0)
            {
                textBox1.Text = inputs[k];
            }*/
            History.Show();
            Hide();
            //Form1.Close();
            //History.Visible
            /*int j = 0;
            if (j % 2 == 0) richTextBox1.Visible = true;
            else richTextBox1.Visible = false;*/
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Formula.Text = Formula.Text + "^(";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            var frm2 = new Const(constants);
            ListBox listbox10 = new ListBox();
            frm2.ShowDialog();
            listbox10.Items.Clear();
            foreach (var constantValue in constants)
            {
                listbox10.Items.Add(constantValue.ToString()); //ñâÿçûâàíèå äàííûõ
            }
            //Const.Show();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            expressionTreeNode = new ExpressionTreeNode(preparsed_expression);
            try
            {
                result = expressionTreeNode.StartParse();

                foreach (var item in result)
                {
                    listBox1.Items.Add(item);
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Âû ââåëè ïóñòóþ ñòðîêó!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            preparsed_expression = textBox1.Text;
        }

        private void panel1_DataContextChanged(object sender, EventArgs e)
        {

        }*/
    }
}
//ïðè ñîçäàíèè êîíñòàíòû ââîäèòñÿ áóêâà ñ êëàâèàòóðû, äîëæíà âûëåçòè íîâàÿ ôîðìà äëÿ ââåäåíèÿ êîíñòàíòû
//âñòàâëÿåì êíîïêó,ïî íàæàíòèþ êîòîðîé âûëåçåò íîâàÿ ôîðìà
//ïðîåêò->äîáàâèòü íîââóþ ôîðìó
//ïî {êíîïêà2_êëèê}
/*
 * constants.CleaR(0
constants.Add(new() {Name ="X", Value = 0.0});
constants.Add(new() {Name ="Constant", Value = 0.0});
constants.Add(new() {Name ="v", Value = 0.0});
inputs.Add(new() {Value = ""});
var frm2 = new Form2(constants);

//Binding list çàïîëíÿåì âûðàæåíèÿìè

frm2.ShowDialog();
äëÿ íåîãðàíè÷åííûõ êîíñòàíò ââåñòè table(flow0layoutpalnel
ïîëó÷èì òàáëè÷êó
â îäíîé ÿ÷åéêå íàçâàíèÿ êîíñòàíòû
âî âòîðîé çíà÷åíèÿ
îïðåäåëÿåì êîë÷èñåâò îñòîëáöîâ è ÿ÷åêê äèíàìè÷åñêè
÷òîáû ýòî ñäåëàòü - ïðè ñîçäàíèè ôîðìû ïåðåäàåì èíôîðìàöèþ î êîëâå çíà÷åíèé è 
òî ÷òî âûøå íå íàäî
!!!DATAGridVIEW
ÍÎÂÛÉ dâñïîìîãàòåëüíûé êëàññ constant values
[DisplayName("const names")]
public string Name{get;set;]
[DisplayName("values")]
public double Value{get; set;]
public override striing TOstring(0{
    return $"{Name]={Value]";

]


ââåðçäó ôîðì.ññ
BindingList<ConstantValues> constants = new(0);


public class Form2 : form
{
    private Bindinglist<ConstantValues>.
..ñì ôîòî... = _constats;
...
datraGridView.DataSource=
}

äîáàâëÿåì listbox ïîñëå frm2 â áàòòîí2êëèê
ïîêàçûâàåì ÷òî ïîëüçîâàòåëü ââåë
frm2.ShowDiealog
listbox1.Items.Clear(0;
foreach(var constantValue int constants0 {
 listbox1.Items.Add(constantValue.ToString(00; //ñâÿçûâàíèå äàííûõ

]

$"error in {e.RowIndex}"

çàïðåòèòü äîáàâëÿòü áëîüøå êîíñòàíò ÷åì âûäàåò ñòðî÷åê ïðîãðàììà
ôääùöãûóêåùô
allowusertoaddrows////ñâîéñòâà ïàíåëè
*/