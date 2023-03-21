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
using NewVersionOfParsing;

namespace GroupProject_106
{
    public class ExpressionTree
    {
        private ExpressionTreeNode root;
        private List<string> parsingList { get; set; }
        public ExpressionTree(List<string> parsingList)
        {
            this.parsingList = parsingList;
            root = new ExpressionTreeNode(Pop());
            CreateTree(root);
        }
        private void CreateTree(ExpressionTreeNode curr)
        {
            if (Parsing.operators.Contains(curr.string_value))
            {
                curr.RightNode = new ExpressionTreeNode(Pop());
                CreateTree(curr.RightNode);
                curr.LeftNode = new ExpressionTreeNode(Pop());
                CreateTree(curr.LeftNode);
            }
            if (Parsing.functions.Contains(curr.string_value))
            {
                curr.RightNode = new ExpressionTreeNode(Pop());
                CreateTree(curr.RightNode);
            }
        }
        public double Tarvase(double x)
        {
            return CountValue(root, x);
        }
        private double CountValue(ExpressionTreeNode elem, double x)
        {
            switch (elem.string_value)
            {
                case "+":
                    return CountValue(elem.RightNode, x) + CountValue(elem.LeftNode, x);
                case "-":
                    return CountValue(elem.LeftNode, x) - CountValue(elem.RightNode, x);
                case "*":
                    return CountValue(elem.RightNode, x) * CountValue(elem.LeftNode, x);
                case "/":
                    return CountValue(elem.LeftNode, x) / CountValue(elem.RightNode, x);
                case "^":
                    return Math.Pow(CountValue(elem.LeftNode, x), CountValue(elem.RightNode, x));
                case "sin":
                    return Math.Sin(CountValue(elem.RightNode, x));
                case "cos":
                    return Math.Cos(CountValue(elem.RightNode, x));
                case "tan":
                    return Math.Tan(CountValue(elem.RightNode, x));
                case "cot":
                    return 1 / Math.Tan(CountValue(elem.RightNode, x));
                case "ln":
                    return Math.Log(CountValue(elem.RightNode, x));
                case "x":
                    return x;
                default: return Convert.ToDouble(elem.string_value);
            }
        }
        private string Pop()
        {
            string save = parsingList[parsingList.Count - 1];
            parsingList.RemoveAt(parsingList.Count - 1);
            return save;
        }


    }
}
