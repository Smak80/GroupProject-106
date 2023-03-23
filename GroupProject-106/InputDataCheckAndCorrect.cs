using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace GroupProject_106
{
    public class InputDataCheckAndCorrect
    {
        private List<string> devidedFormula;
        private string[] funcs = { "cos", "sin", "tan", "cot", "ln", "x"};
        private string[] operators = { "+", "-", "*", "/", "^" };
        private double low, up;
        private List<string> namesConstants;
        private Dictionary<string, string> namesAndConsts = new Dictionary<string, string> { ["pi"] = "3,14159", ["e"] = "2,71828" };
        public List<string> NamesConstants => namesConstants;
        public InputDataCheckAndCorrect(string expr, double low, double up)
        {
            this.up = up;
            this.low = low;
            devidedFormula = DevideFormula(expr);
            namesConstants = GetNamesConstants();
        }
        public string PullExpr()
        {
            string result = "";
            foreach (string s in devidedFormula)
            {
                result += s;
            }
            return result;
        }
        public void RenameConsts(BindingList<ConstantValues> consts)
        {
            foreach (ConstantValues v in consts)
            {
                namesAndConsts.Add(v.Name, v.Value.ToString());
            }
            for (int i = 0; i < devidedFormula.Count; i++)
            {
                foreach (var v in namesAndConsts)
                {
                    if (devidedFormula[i].Equals(v.Key)) devidedFormula[i] = v.Value;
                }
            }
        }
        public void ChangeBinMinusToUnary()
        {
            for (int i = 0; i < devidedFormula.Count; i++)
            {
                if (devidedFormula[i].Equals("-") && (i != 0 && (IsOperator(devidedFormula[i - 1]) && !devidedFormula[i].Equals("+") || devidedFormula[i].Equals("(")) || i == 0))
                {
                    devidedFormula[i] = "(";
                    devidedFormula.Insert(i + 1, "0");
                    devidedFormula.Insert(i + 2, "-");
                    devidedFormula.Insert(i + 3, "1");
                    devidedFormula.Insert(i + 4, ")");
                    devidedFormula.Insert(i + 5, "*");
                }
            }
        }
        public bool InputDataDiagnostic()
        {
            return BracketDiagnostic() && SgnDiagnostic() && BoundsDiagnostic();
        }
        private List<string> GetNamesConstants()
        {
            List<string> result = new List<string>();
            foreach (string s in devidedFormula)
            {
                if (!IsOperator(s) && !IsFunc(s) && !s.Equals("(") && !IsNumber(s) && !s.Equals(")") && !s.Equals(", ") && !s.Equals("e") && !s.Equals("pi"))
                {
                    result.Add(s);
                }
            }
            return result;
        }

        private List<string> DevideFormula(string expr)
        {
            List<string> result = new List<string>();
            string save = "";
            for (int i = 0; i <= expr.Length; i++)
            {
                if (i == expr.Length)
                {
                    if (!save.Equals("")) result.Add(save);
                }
                else if (IsOperator(expr[i] + "") || expr[i] == '(' || expr[i] == ')' || (expr[i] == ',' && i + 1 != expr.Length && expr[i + 1] == ' '))
                {
                    if (!save.Equals("")) result.Add(save);
                    save = "";
                    if (expr[i] != ',') result.Add(expr[i] + "");
                    else devidedFormula.Add(", ");
                }
                else if (expr[i] != ' ')
                {
                    save += expr[i];
                }
            }
            return result;
        }
        private bool BoundsDiagnostic()
        {
            if (!(up - low >= 0)) MessageBox.Show("Ошибка! Неправильно заданы пределы интегрирования.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return up - low > 0;
        }
        private bool BracketDiagnostic()
        {
            Stack<string> c = new Stack<string>();
            foreach (string item in devidedFormula)
            {
                if (item.Equals("("))
                {
                    c.Push(item);
                }
                else if (item.Equals(")"))
                {
                    if (c.Count > 0)
                    {
                        c.Pop();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка расставления скобок , попробуйте убрать скобку.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            if (c.Count > 0)
            {
                MessageBox.Show("Ошибка расставления скобок , попробуйте куда-нибудь поставить скобку.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        private bool SgnDiagnostic()
        {
            if (devidedFormula.Count == 0)
            {
                MessageBox.Show("Ошибка! Введите хоть что-то!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            for (int i = 0; i < devidedFormula.Count; i++)
            {
                if (IsOperator(devidedFormula[i]) && (i + 1 != devidedFormula.Count && (IsOperator(devidedFormula[i + 1]) || devidedFormula[i + 1].Equals(")")) || i + 1 == devidedFormula.Count))
                {
                    MessageBox.Show("Ошибка! После операции должен стоять операнд. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (IsOperator(devidedFormula[i]) && i == 0)
                {
                    MessageBox.Show("Ошибка! Перед операцией должен стоять операнд. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (devidedFormula[i].Equals("(") && i + 1 != devidedFormula.Count && devidedFormula[i + 1].Equals(")"))
                {
                    MessageBox.Show("Ошибка! Скобки должны быть чем-то заполнены.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (devidedFormula[i].Equals("(") && i != 0 && (devidedFormula[i - 1].Equals("x") || IsNumber(devidedFormula[i - 1])))
                {
                    MessageBox.Show("Ошибка! Перед откр. скобкой должна стоять операция или откр. скобка.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (devidedFormula[i].Equals(")") && i + 1 != devidedFormula.Count && !devidedFormula[i + 1].Equals(")") && !IsOperator(devidedFormula[i + 1]))
                {
                    MessageBox.Show("Ошибка! После закр. скобки должна стоять операция или закр. скобка.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (IsFunc(devidedFormula[i]) && !devidedFormula[i].Equals("x") && (i + 1 != devidedFormula.Count && !devidedFormula[i + 1].Equals("(") || i + 1 == devidedFormula.Count))
                {
                    MessageBox.Show("Ошибка! После имени функции должна стоять откр. скобка.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if ((devidedFormula[i].Equals("x") || IsNumber(devidedFormula[i])) && i + 1 != devidedFormula.Count && !IsOperator(devidedFormula[i + 1]) && !devidedFormula[i + 1].Equals(")"))
                {
                    MessageBox.Show("Ошибка! После операнда должна стоять операция или закр. скобка.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private bool IsNumber(string? str)
        {
            if (str == null) return false;
            bool flag = false;
            try
            {
                Convert.ToDouble(str);
                flag = true;
            }
            catch { }
            return flag;
        }
        private bool IsFunc(string? str)
        {
            if (str == null) return false;
            bool flag = false;
            for (int j = 0; j < funcs.Length; j++)
            {
                if (funcs[j].Equals(str))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        private bool IsOperator(string? str)
        {
            if (str == null) return false;
            bool flag = false;
            foreach (var item in operators)
            {
                if (item.Equals(str))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}