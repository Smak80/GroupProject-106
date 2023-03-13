using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing
{
    public enum Side
    {
        Left,
        Right
    }
    internal class ExpressionTreeNode
    {
        internal string _preparsed_expression;

        private List<string> list_of_parsed_elem = new List<string>();

        private readonly List<string> operators = new() { "(", "+", "-", "*", "/", "^", ")", "(", "()" };

        private readonly List<string> functions = new() 
        { "sin", "cos", "tan", "cot", 
          "asin", "acos", "atan", "acot",
          "loge", "log10", "log", "exp",
          "tanh", "sinh", "cosh", "coth",
          "atanh", "asinh", "acosh", "acoth"
        };
        internal ExpressionTreeNode LeftNode { get; set; }

        internal ExpressionTreeNode RightNode { get; set; }

        internal  ExpressionTreeNode ParentNode { get; set; }

        public ExpressionTreeNode(string preparsed_expression)
        {
            _preparsed_expression = preparsed_expression;

        }

        public List<string> StartParse ()
        {
            if (_preparsed_expression == null)
            {
                return list_of_parsed_elem;
            }

            else
            {
                int count_sym = 0;
                string operand_1 = "";
                string operand_2 = "";
                string last_operation = "";

                while (count_sym < _preparsed_expression.Length)
                {
                    int currentIndex = list_of_parsed_elem.Count - 1;
                    if (_preparsed_expression[count_sym] == '(')
                    {
                        list_of_parsed_elem.Add(_preparsed_expression[count_sym].ToString());
                        currentIndex = list_of_parsed_elem.Count - 1;
                        while (operators.Contains(list_of_parsed_elem[currentIndex]) && operators.LastIndexOf(_preparsed_expression[count_sym].ToString()) > operators.IndexOf(list_of_parsed_elem[currentIndex]))
                        {
                            list_of_parsed_elem[currentIndex] = list_of_parsed_elem[currentIndex - 1];
                            currentIndex--;
                        }
                        list_of_parsed_elem[currentIndex] = _preparsed_expression[count_sym].ToString();
                        last_operation = _preparsed_expression[count_sym].ToString();
                        count_sym++;
                    }
                    else if (_preparsed_expression[count_sym] == ')')
                    {
                        currentIndex = list_of_parsed_elem.Count - 1;
                        list_of_parsed_elem[list_of_parsed_elem.LastIndexOf("(")] = "()";
                        last_operation = "()";
                        count_sym++;
                    }
                    else if (operators.Contains(_preparsed_expression[count_sym].ToString()))
                    {
                        currentIndex = list_of_parsed_elem.Count - 1;
                        //Always after (
                        if (last_operation == "(")
                        {
                            int index = list_of_parsed_elem.LastIndexOf(last_operation);
                            list_of_parsed_elem.Add(last_operation);
                            while (currentIndex >= index)
                            {
                                list_of_parsed_elem[currentIndex + 1] = list_of_parsed_elem[currentIndex];
                                currentIndex--;
                            }

                            list_of_parsed_elem[currentIndex + 1] = _preparsed_expression[count_sym].ToString();
                        }
                        //priority
                        else
                        {
                            currentIndex = list_of_parsed_elem.Count - 1;
                            list_of_parsed_elem.Add(last_operation.ToString());
                            while (
                                operators.Contains(list_of_parsed_elem[currentIndex]) &&
                                operators.IndexOf(_preparsed_expression[count_sym].ToString()) >
                                operators.IndexOf(list_of_parsed_elem[currentIndex]))
                            {
                                list_of_parsed_elem[currentIndex + 1] = list_of_parsed_elem[currentIndex];
                                currentIndex--;
                            }

                            list_of_parsed_elem[currentIndex + 1] = _preparsed_expression[count_sym].ToString();
                        }

                        last_operation = _preparsed_expression[count_sym].ToString();
                        count_sym++;
                    }

                    if (operand_1 == "")
                    {
                        while (count_sym < _preparsed_expression.Length && !operators.Contains(_preparsed_expression[count_sym].ToString()))
                        {
                            operand_1 += _preparsed_expression[count_sym];
                            count_sym++;
                        }
                        list_of_parsed_elem.Add(operand_1);
                        if (functions.Contains(operand_1))
                        {
                            list_of_parsed_elem.Add("Arg");
                        }
                        operand_2 = "";

                    }

                    
                    else if (operand_2 == "")
                    {
                        currentIndex = list_of_parsed_elem.Count - 1;
                        while (count_sym < _preparsed_expression.Length &&
                        !operators.Contains(_preparsed_expression[count_sym].ToString()))
                        {
                            operand_2 += _preparsed_expression[count_sym];
                            count_sym++;
                        }

                        int index = list_of_parsed_elem.LastIndexOf(last_operation.ToString());
                        int bracketIndex = list_of_parsed_elem.IndexOf("(");
                        if (bracketIndex > 0 &&
                            list_of_parsed_elem.LastIndexOf(last_operation.ToString(), bracketIndex) > 0 &&
                            list_of_parsed_elem.LastIndexOf(last_operation.ToString(), bracketIndex) < index)
                        {
                            index = list_of_parsed_elem.LastIndexOf(last_operation.ToString(), list_of_parsed_elem.IndexOf("("));
                        }
                        list_of_parsed_elem.Add(operand_2);
                        if (functions.Contains(operand_2))
                        {
                            list_of_parsed_elem.Add("Arg");
                        }

                        currentIndex = list_of_parsed_elem.Count - 1;
                        while (currentIndex > index)
                        {
                            if (functions.Contains(operand_2))
                            {
                                list_of_parsed_elem[currentIndex] = list_of_parsed_elem[currentIndex - 2];
                            }
                            else
                            {
                                list_of_parsed_elem[currentIndex] = list_of_parsed_elem[currentIndex - 1];
                            }
                            currentIndex--;
                        }

                        list_of_parsed_elem[index] = operand_2;
                        if (functions.Contains(operand_2))
                        {
                            list_of_parsed_elem[index + 1] = "Arg";
                        }
                        operand_2 = "";

                    }
                }
                
            }
            return list_of_parsed_elem;
            
        }

        public Side? NodeSide =>
            ParentNode == null ? null : ParentNode.LeftNode == this ? Side.Left : Side.Right; //расположение узла относительно родителя

        public override string ToString()
        {
            return _preparsed_expression.ToString();
        }

        //public ExpressionTreeNode FindNode(string expression, )
    }
}
