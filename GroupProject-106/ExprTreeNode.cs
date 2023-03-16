using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_106
{
    public class ExprTreeNode
    {
        private string oper;
        private ExprTreeNode? left;
        private ExprTreeNode? right;
        public string Oper { get { return oper; } set { oper = value; } }
        public ExprTreeNode Left { get { return left ?? new ExprTreeNode(""); } set { left = value; } }
        public ExprTreeNode Right { get { return right ?? new ExprTreeNode(""); } set { right = value; } }
        public ExprTreeNode(string oper)
        {
            this.oper = oper;
        }
    }
}

