using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject_106
{
    public class ExpressionTree
    {
        /*private ExpressionTreeNode root;
        public ExpressionTreeNode Root => root;
        public ExpressionTree(string expression)
        {
            root = new ExpressionTreeNode(expression,1);
        }*/
        private ExpressionTreeNode Root { get; set; }

        private int Count { get; set; }

        public void Add(string expression)
        {
            if (Root == null)
            {
                Root = new ExpressionTreeNode(expression);
                Count = 1;
                return;
            }

            Root.Add(expression);
            Count++;
        }


    }
}
