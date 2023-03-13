namespace Parsing
{
    public partial class Form1 : Form
    {
        ExpressionTreeNode expressionTreeNode;
        string preparsed_expression;
        List<string> result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Вы ввели пустую строку!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            preparsed_expression = textBox1.Text;
        }

        private void panel1_DataContextChanged(object sender, EventArgs e)
        {

        }
    }
}