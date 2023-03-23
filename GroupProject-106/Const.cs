using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Const : Form
    {

        public List<string> data = new List<string>();
        private BindingList<ConstantValues>? _constants;
        public Const(BindingList<ConstantValues> constants, List<string> names)
        {
            InitializeComponent();
            foreach (var name in names)
            {
                constants.Add(new() { Name = name, Value = 0.0 });
            }
            _constants = constants;
            dataGridView1.DataSource = _constants;
            dataGridView1.DataError += dataGridView1_DataError;
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error");
        }
        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
