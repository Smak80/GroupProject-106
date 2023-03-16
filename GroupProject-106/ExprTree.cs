using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_106
{
    public class ExprTree
    {
        private ExprTreeNode root;
        public List<string> listOfParsedElems;
        public ExprTreeNode Root => root;
        private readonly List<string> operators = new List<string>() { "+", "-", "*", "/", "^", ")", "(", "()" };
        private readonly List<string> functions = new List<string>() { "sin", "cos", "tan", "cot", "ln" };
        public ExprTree(string preparsedExpr)
        {
            listOfParsedElems = new List<string>();
            StartParse(preparsedExpr);
            root = new ExprTreeNode(Pop());
            CreateTree(root);
        }
        public double ExprTreeTarvase(ExprTreeNode root, double x)
        {
            switch (root.Oper)
            {
                case "+":
                    return ExprTreeTarvase(root.Left, x) + ExprTreeTarvase(root.Right, x);
                case "-":
                    return ExprTreeTarvase(root.Left, x) - ExprTreeTarvase(root.Right, x);
                case "*":
                    return ExprTreeTarvase(root.Left, x) * ExprTreeTarvase(root.Right, x);
                case "/":
                    return ExprTreeTarvase(root.Left, x) / ExprTreeTarvase(root.Right, x);
                case "^":
                    return Math.Pow(ExprTreeTarvase(root.Left, x), ExprTreeTarvase(root.Right, x));
                case "()":
                    switch (root.Left.Oper)
                    {
                        case "sin":
                            return Math.Sin(ExprTreeTarvase(root.Right, x));
                        case "cos":
                            return Math.Cos(ExprTreeTarvase(root.Right, x));
                        case "tan":
                            return Math.Tan(ExprTreeTarvase(root.Right, x));
                        case "cot":
                            return 1 / Math.Tan(ExprTreeTarvase(root.Right, x));
                        case "ln":
                            return Math.Log(ExprTreeTarvase(root.Right, x));
                    }
                    break;
                case "x": return x;
                default: return Convert.ToDouble(root.Oper);
            }
            return 18;
        }
        private void CreateTree(ExprTreeNode root)
        {
            if (IsOperator(root.Oper))
            {
                string save = Pop();
                if (save.Equals("Arg")) save = Pop();
                root.Right = new ExprTreeNode(save);
                CreateTree(root.Right);
                save = Pop();
                if (save.Equals("Arg")) save = Pop();
                root.Left = new ExprTreeNode(save);
                CreateTree(root.Left);
            }
        }
        private string Pop()
        {
            string save = listOfParsedElems[listOfParsedElems.Count - 1];
            listOfParsedElems.RemoveAt(listOfParsedElems.Count - 1);
            return save;
        }
        private bool IsOperator(string oper)
        {
            foreach (string item in operators)
            {
                if (item.Equals(oper)) return true;
            }
            return false;
        }
        private void StartParse(string preparsedExpr)
        {
            int count_sym = 0;
            string operand_1 = "";
            string operand_2 = "";
            string last_operation = "";

            while (count_sym < preparsedExpr.Length)
            {
                int currentIndex = listOfParsedElems.Count - 1;
                if (preparsedExpr[count_sym] == '(')
                {
                    listOfParsedElems.Add(preparsedExpr[count_sym].ToString());
                    while (operators.Contains(listOfParsedElems[currentIndex]) && operators.LastIndexOf(preparsedExpr[count_sym].ToString()) > operators.IndexOf(listOfParsedElems[currentIndex]))
                    {
                        listOfParsedElems[currentIndex + 1] = listOfParsedElems[currentIndex]; //вставляем скобку перед последней операцией
                        currentIndex--;
                    }
                    listOfParsedElems[currentIndex + 1] = preparsedExpr[count_sym].ToString();
                    last_operation = preparsedExpr[count_sym].ToString();
                    count_sym++;
                    continue;
                }
                else if (preparsedExpr[count_sym] == ')')
                {
                    currentIndex = listOfParsedElems.Count - 1;
                    listOfParsedElems[listOfParsedElems.LastIndexOf("(")] = "()";
                    last_operation = "()";
                    count_sym++;
                    continue;
                }
                else if (operators.Contains(preparsedExpr[count_sym].ToString()))
                {
                    currentIndex = listOfParsedElems.Count - 1;
                    if (last_operation == "(")
                    {
                        int index = listOfParsedElems.LastIndexOf(last_operation);
                        listOfParsedElems.Add(last_operation);
                        while (currentIndex >= index)
                        {
                            listOfParsedElems[currentIndex + 1] = listOfParsedElems[currentIndex]; //вставляем операцию перед скобкой
                            currentIndex--;
                        }

                        listOfParsedElems[currentIndex + 1] = preparsedExpr[count_sym].ToString();
                    }
                    //проверка на приоритет
                    else
                    {
                        currentIndex = listOfParsedElems.Count - 1;
                        listOfParsedElems.Add(last_operation.ToString());
                        while (
                            operators.Contains(listOfParsedElems[currentIndex]) &&
                            operators.IndexOf(preparsedExpr[count_sym].ToString()) >
                            operators.IndexOf(listOfParsedElems[currentIndex]))
                        {
                            listOfParsedElems[currentIndex + 1] = listOfParsedElems[currentIndex];
                            currentIndex--;
                        }

                        listOfParsedElems[currentIndex + 1] = preparsedExpr[count_sym].ToString();
                    }

                    last_operation = preparsedExpr[count_sym].ToString();
                    count_sym++;
                }

                else if (operand_1 == "")
                {
                    while (count_sym < preparsedExpr.Length && !operators.Contains(preparsedExpr[count_sym].ToString()))
                    {
                        operand_1 += preparsedExpr[count_sym];
                        count_sym++;
                    }
                    listOfParsedElems.Add(operand_1);
                    if (functions.Contains(operand_1))
                    {
                        listOfParsedElems.Add("Arg");
                    }
                    operand_2 = "";

                }


                else if (operand_2 == "")
                {
                    currentIndex = listOfParsedElems.Count - 1;
                    while (count_sym < preparsedExpr.Length &&
                    !operators.Contains(preparsedExpr[count_sym].ToString()))
                    {
                        operand_2 += preparsedExpr[count_sym];
                        count_sym++;
                    }

                    int index = listOfParsedElems.LastIndexOf(last_operation.ToString());
                    int bracketIndex = listOfParsedElems.IndexOf("(");
                    if (bracketIndex > 0 &&
                        listOfParsedElems.LastIndexOf(last_operation.ToString(), bracketIndex) > 0 &&
                        listOfParsedElems.LastIndexOf(last_operation.ToString(), bracketIndex) < index)
                    {
                        index = listOfParsedElems.LastIndexOf(last_operation.ToString(), listOfParsedElems.IndexOf("("));
                    }
                    listOfParsedElems.Add(operand_2);
                    if (functions.Contains(operand_2))
                    {
                        listOfParsedElems.Add("Arg");
                    }

                    currentIndex = listOfParsedElems.Count - 1;
                    while (currentIndex > index)
                    {
                        if (functions.Contains(operand_2))
                        {
                            listOfParsedElems[currentIndex] = listOfParsedElems[currentIndex - 2]; //сдвигаем на 2 символа, если композиция
                        }
                        else
                        {
                            listOfParsedElems[currentIndex] = listOfParsedElems[currentIndex - 1];
                        }
                        currentIndex--;
                    }

                    listOfParsedElems[index] = operand_2;
                    if (functions.Contains(operand_2))
                    {
                        listOfParsedElems[index + 1] = "Arg";
                    }
                    operand_2 = "";

                }
            }

        }
    }
}

