using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_106
{
    public class ExpressionTreeNode
    {
        internal string _preparsed_expression;

        private List<string> list_of_parsed_elem = new List<string>();

        internal readonly List<string> operators = new List<string>() { "(", "+", "-", "*", "/", "^", ")", "(", "()" };

        internal readonly List<string> functions = new List<string>()
        { "sin", "cos", "tan", "cot",
          "asin", "acos", "atan", "acot",
          "loge", "log10", "log", "exp",
          "tanh", "sinh", "cosh", "coth",
          "atanh", "asinh", "acosh", "acoth"
        };
        internal ExpressionTreeNode LeftNode { get; set; }

        internal ExpressionTreeNode RightNode { get; set; }

        private string list_elem { get; set; } //добавляемое значение


        public ExpressionTreeNode(string func, int a = 0)
        {
            list_elem = func;
            LeftNode = null;
            RightNode = null;
        }

        public ExpressionTreeNode(string func, ExpressionTreeNode leftNode, ExpressionTreeNode rightNode)
        {
            list_elem = func;
            LeftNode = leftNode;
            RightNode = rightNode;
        }



        public void Add(string list_elem)
        {
            var Node = new ExpressionTreeNode(list_elem);

            if (RightNode == null)
            {
                if (operators.Contains(list_elem)) //если это операция
                {
                    RightNode = Node; //кладём в правое поддерево
                }

                else
                {
                    RightNode.Add(list_elem); //если это функция или константа, то вызываем рекурсивно
                }
            }
            if (LeftNode == null)
            {
                if (!operators.Contains(list_elem))
                {
                    LeftNode = Node;
                }
                else
                {
                    LeftNode.Add(list_elem);
                }
            }


        }

        public List<ExpressionTreeNode> PostOrder(ExpressionTreeNode node) //обход слева-направо
        {
            var list = new List<ExpressionTreeNode>();
            if (node != null)
            {
                if (node.LeftNode != null)
                {
                    list.AddRange(PostOrder(node.LeftNode));
                }
                if (node.RightNode != null)
                {
                    list.AddRange(PostOrder(node.RightNode));
                }
                list.Add(node);
            }
            return list;
        }



        public ExpressionTreeNode(string preparsed_expression)
        {
            _preparsed_expression = preparsed_expression; //начальная строка, вводимая пользователем

        }

        public List<string> StartParse()
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
                        while (operators.Contains(list_of_parsed_elem[currentIndex]) && operators.LastIndexOf(_preparsed_expression[count_sym].ToString()) > operators.IndexOf(list_of_parsed_elem[currentIndex]))
                        {
                            list_of_parsed_elem[currentIndex + 1] = list_of_parsed_elem[currentIndex]; //вставляем скобку перед последней операцией
                            currentIndex--;
                        }
                        list_of_parsed_elem[currentIndex + 1] = _preparsed_expression[count_sym].ToString();
                        last_operation = _preparsed_expression[count_sym].ToString();
                        count_sym++;
                        continue;
                    }
                    else if (_preparsed_expression[count_sym] == ')')
                    {
                        currentIndex = list_of_parsed_elem.Count - 1;
                        list_of_parsed_elem[list_of_parsed_elem.LastIndexOf("(")] = "()";
                        last_operation = "()";
                        count_sym++;
                        continue;
                    }
                    else if (operators.Contains(_preparsed_expression[count_sym].ToString()))
                    {
                        currentIndex = list_of_parsed_elem.Count - 1;
                        if (last_operation == "(")
                        {
                            int index = list_of_parsed_elem.LastIndexOf(last_operation);
                            list_of_parsed_elem.Add(last_operation);
                            while (currentIndex >= index)
                            {
                                list_of_parsed_elem[currentIndex + 1] = list_of_parsed_elem[currentIndex]; //вставляем операцию перед скобкой
                                currentIndex--;
                            }

                            list_of_parsed_elem[currentIndex + 1] = _preparsed_expression[count_sym].ToString();
                        }
                        //проверка на приоритет
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

                    else if (operand_1 == "")
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
                                list_of_parsed_elem[currentIndex] = list_of_parsed_elem[currentIndex - 2]; //сдвигаем на 2 символа, если композиция
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




        public override string ToString()
        {
            return _preparsed_expression.ToString();
        }

        /*public double ExprTreeTarvase(ExpressionTreeNode self , double x)
        {
            switch (self.list_elem)
            {
                case "+":
                    return ExprTreeTarvase(self.LeftNode, x) + ExprTreeTarvase(self.RightNode, x);
                case "-":
                    return ExprTreeTarvase(self.LeftNode, x) - ExprTreeTarvase(self.RightNode, x);
                case "*":
                    return ExprTreeTarvase(self.LeftNode, x) * ExprTreeTarvase(self.RightNode, x);
                case "/":
                    return ExprTreeTarvase(self.LeftNode, x) / ExprTreeTarvase(self.RightNode, x);
                case "^":
                    return Math.Pow(ExprTreeTarvase(self.LeftNode, x),ExprTreeTarvase(self.RightNode, x));
                case "()":
                    switch (self.LeftNode.list_elem)
                    {
                        case "sin":
                            return Math.Sin(ExprTreeTarvase(self.RightNode , x));
                        case "cos":
                            return Math.Cos(ExprTreeTarvase(self.RightNode, x));
                        case "tan":
                            return Math.Tan(ExprTreeTarvase(self.RightNode, x));
                        case "cot":
                            return 1/Math.Tan(ExprTreeTarvase(self.RightNode, x));
                        case "ln":
                            return Math.Log(ExprTreeTarvase(self.RightNode, x));
                    }
                    break;
                case "x": return x;
                default: return Convert.ToDouble(self.list_elem);
            }
            return 8;
        }*/
    }
}
