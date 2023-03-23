using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class ConstantValues
    {
        [DisplayName("константа")]
        public string Name
        {
            get; set;
        }
        [DisplayName("значение")]
        public double Value
        {
            get; set;
        }
        public override string ToString()
        {
            return $"{Name}={Value}";

        }
    }
}
