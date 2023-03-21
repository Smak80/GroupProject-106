using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfParsing
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




        

        public void Insert(params string[] parsed_elems)
        {
            for (int j = 0; j < parsed_elems.Length; j++)
            {
                if (parsed_elems[j].Any(item => item >= 48 && item <= 57))
                {
                    if (RightNode == null)
                    {
                        RightNode = new ExpressionTreeNode(parsed_elems[j]);
                    }
                }

                else if (parsed_elems[j] == "x")
                {
                    if (LeftNode == null)
                    {
                        LeftNode = new ExpressionTreeNode(parsed_elems[j]);
                    }
                }

                else if (Parsing.functions.Contains(parsed_elems[j]))
                {
                    if (LeftNode == null)
                    {
                        LeftNode = new ExpressionTreeNode(parsed_elems[j]);
                    }
                }
                else if (Parsing.operators.Contains(parsed_elems[j]) && parsed_elems.Length == 2)
                {
                    if (RightNode == null)
                    {
                        RightNode = new ExpressionTreeNode(parsed_elems[0]);
                    }
                    if (LeftNode == null)
                    {
                        LeftNode = new ExpressionTreeNode(parsed_elems[1]);

                    }
                }
                else if (Parsing.operators.Contains(parsed_elems[j]) && parsed_elems.Length == 1)
                {
                    if (RightNode == null)
                    {
                        RightNode = new ExpressionTreeNode(parsed_elems[0]);
                    }
                    
                }
            }

        }
        

        

    }
}
