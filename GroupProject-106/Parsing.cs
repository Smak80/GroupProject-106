using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_106
{
    public class Parsing
    {
        private string preparsed_expression = "";
        private List<string> preparsed_list = new List<string>();
        private List<string> parsed_expression = new List<string>();
        private Stack<string> preparsed_expression_stack = new Stack<string>();
        public static readonly List<string> functions = new List<string> { "sin", "cos", "tan", "cot", "ln" };
        public static readonly List<string> operators = new List<string> { "+", "-", "*", "/", "^" };
        public Parsing(string preparsed_expression)
        {
            this.preparsed_expression = preparsed_expression;
            DevideString();
        }
        private void DevideString()
        {
            string save = "";
            for (int i = 0; i <= preparsed_expression.Length; i++)
            {
                if (i == preparsed_expression.Length)
                {
                    if (!save.Equals(""))
                        preparsed_list.Add(save);
                }
                else
                {
                    if (operators.Contains(preparsed_expression[i] + "") || preparsed_expression[i] == '(' || preparsed_expression[i] == ')')
                    {
                        if (!save.Equals("")) preparsed_list.Add(save);
                        save = "";
                        preparsed_list.Add(preparsed_expression[i] + "");
                    }
                    else
                    {
                        save += preparsed_expression[i];
                    }
                }
            }
        }
        public List<string> StartParse()
        {
            bool isNumber = false;
            double num;
            foreach (var item in preparsed_list)
            {
                isNumber = double.TryParse(item.ToString(), out num);
                if (preparsed_expression_stack.Count != 0)
                {

                    if (operators.Contains(item.ToString()) && operators.IndexOf(item.ToString()) > operators.IndexOf(preparsed_expression_stack.Peek()))
                    {
                        preparsed_expression_stack.Push(item.ToString());

                    }
                    else if (operators.Contains(item.ToString()) && operators.IndexOf(item.ToString()) < operators.IndexOf(preparsed_expression_stack.Peek()))
                    {
                        if (functions.Contains(item))
                        {
                            while (operators.Contains(preparsed_expression_stack.Peek()))
                            {
                                parsed_expression.Add(preparsed_expression_stack.Pop());
                            }
                            preparsed_expression_stack.Push(item);
                        }
                        else if (!functions.Contains(item))
                        {
                            if (preparsed_expression_stack.Count > 0)
                            {
                                while (preparsed_expression_stack.Count > 0 && operators.IndexOf(item.ToString()) < operators.IndexOf(preparsed_expression_stack.Peek()))
                                {
                                    parsed_expression.Add(preparsed_expression_stack.Pop());
                                }

                                preparsed_expression_stack.Push(item.ToString());
                            }

                        }
                    }
                    else if (functions.Contains(item))
                    {
                        preparsed_expression_stack.Push(item);


                    }
                    else if (item.ToString() == "(")
                    {
                        preparsed_expression_stack.Push(item);
                    }

                    else if (item.ToString() == ")" && !preparsed_expression_stack.Contains("sin") &&
                             !preparsed_expression_stack.Contains("cos") && !preparsed_expression_stack.Contains("tan")
                             && !preparsed_expression_stack.Contains("cot") && !preparsed_expression_stack.Contains("ln"))
                    {
                        while (preparsed_expression_stack.Count > 0 && preparsed_expression_stack.Peek() != "(")
                        {
                            parsed_expression.Add(preparsed_expression_stack.Pop());

                        }
                        if (preparsed_expression_stack.Count > 0)
                        {
                            preparsed_expression_stack.Pop();
                        }

                    }
                    else if (item.ToString() == ")" && (preparsed_expression_stack.Contains("sin") ||
                             preparsed_expression_stack.Contains("cos") || preparsed_expression_stack.Contains("tan")
                             || preparsed_expression_stack.Contains("cot") || preparsed_expression_stack.Contains("ln")))
                    {
                        while (preparsed_expression_stack.Peek() != "sin" && preparsed_expression_stack.Peek() != "cos"
                               && preparsed_expression_stack.Peek() != "tan" && preparsed_expression_stack.Peek() != "cot"
                               && preparsed_expression_stack.Peek() != "ln")
                        {
                            if (preparsed_expression_stack.Peek() != "(")
                            {
                                parsed_expression.Add(preparsed_expression_stack.Pop());
                            }
                            else
                            {
                                preparsed_expression_stack.Pop();
                            }

                        }
                        if (isNumber || item == "x")
                        {
                            parsed_expression.Add(item.ToString());
                            parsed_expression.Add(preparsed_expression_stack.Pop());
                        }
                        else
                            parsed_expression.Add(preparsed_expression_stack.Pop());
                    }
                    else if (isNumber || item == "x")
                    {
                        parsed_expression.Add(item.ToString());
                    }
                }
                else if (preparsed_expression_stack.Count == 0)
                {

                    if (operators.Contains(item.ToString()) || functions.Contains(item))
                    {
                        if (functions.Contains(item))
                        {
                            preparsed_expression_stack.Push(item);
                        }
                        else
                            preparsed_expression_stack.Push(item.ToString());

                    }
                    else if (isNumber || item == "x")
                    {
                        parsed_expression.Add(item.ToString());
                    }
                    else if (item.ToString() == "(")
                    {
                        preparsed_expression_stack.Push(item.ToString());

                    }
                }

            }
            while (preparsed_expression_stack.Count() > 0)
            {
                parsed_expression.Add(preparsed_expression_stack.Pop());
            }
            return parsed_expression;
        }
    }
}

