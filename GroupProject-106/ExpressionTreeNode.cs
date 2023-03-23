using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_106
{
    public class ExpressionTreeNode
    {
        public string string_value;
        public ExpressionTreeNode LeftNode { get; set; }

        public ExpressionTreeNode RightNode { get; set; }

        public ExpressionTreeNode(string expression)
        {
            string_value = expression;
        }
        public ExpressionTreeNode()
        {

        }  

    }
}
