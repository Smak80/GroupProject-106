using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_106
{
    public class InputDataCheckAndCorrect
    {
        private string expr;
        private string[] funcs = { "cos", "sin", "tg", "cot", "ln" , "x" };
        private Dictionary<string, string> namesAndConsts = new Dictionary<string, string> { ["pi"] = "3,14159" , ["e"] = "2,71828" };
        public InputDataCheckAndCorrect(string expr) 
        {
            this.expr = ExprAdjustment(expr);
        }

        public bool InputDataDiagnostic() 
        {
            return BracketDiagnostic() && WordDiagnostic() && SgnDiagnostic();
        }
        private bool BracketDiagnostic() 
        {
            Stack<char> c = new Stack<char>();
            Stack<int> ind = new Stack<int>();
            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == '(')
                {
                    c.Push(expr[i]);
                    ind.Push(i);
                }
                else if (expr[i] == ')')
                {
                    if (c.Count > 0)
                    {
                        c.Pop();
                        ind.Pop();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка расставления скобок , попробуйте убрать скобку на " + (i + 1) + " месте.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            if (c.Count > 0)
            {
                MessageBox.Show("Ошибка расставления скобок , попробуйте куда-нибудь поставить скобку." , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        private bool WordDiagnostic() 
        {
            string save = "";
            for (int i = 0; i <= expr.Length; i++)
            {
                if (i == expr.Length || expr[i] == '(' || expr[i] == ')' ||  expr[i] == ',' || IsSgn(expr[i]))
                {
                    if (!IsFunc(save) && !IsNumber(save)&&!save.Equals(""))
                    {
                        MessageBox.Show("Ошибка! Не найдена функция или константа с именем " + save + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    save = "";
                }
                else save += expr[i];
            }
            return true;
        }
        private bool SgnDiagnostic()
        {
            if (expr.Length == 0)
            {
                MessageBox.Show("Ошибка! Введите хоть что-то!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            string save = "";
            for (int i = 0; i <= expr.Length; i++)
            {
                if (i == expr.Length && (save.Equals("") || IsNumber(save))) return true;
                else if (i == expr.Length )
                {
                    MessageBox.Show("Ошибка! После имени функции должна стоять откр. скобка.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (expr[i] == '(' || expr[i] == ')' || IsSgn(expr[i])) save = "";
                else save += expr[i];
                if (i == 0 && (expr[i] == ',' || IsSgn(expr[i]) && expr[i] != '-'))
                {
                    MessageBox.Show("Ошибка! Это " + expr[i] + " не может стоять вначале.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (i + 1 == expr.Length && (expr[i] == ',' || IsSgn(expr[i])))
                {
                    MessageBox.Show("Ошибка! Это " + expr[i] + " не может стоять в конце.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (IsSgn(expr[i]) && i + 1 != expr.Length && (IsSgn(expr[i + 1]) || expr[i + 1] == ',' || expr[i + 1] == ')'))
                {
                    MessageBox.Show("Ошибка! После операции должен стоять операнд. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (IsSgn(expr[i]) && expr[i] != '-' && i != 0 && (expr[i - 1] == ',' || expr[i - 1] == '('))
                {
                    MessageBox.Show("Ошибка! Перед операцией должен стоять операнд. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (expr[i] == '-' && i != 0 && expr[i - 1] == ',')
                {
                    MessageBox.Show("Ошибка! Перед минусом не может стоять запятая. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (expr[i] == '(' && i + 1 != expr.Length && (expr[i + 1] == ',' || expr[i + 1] == ')'))
                {
                    MessageBox.Show("Ошибка! Скобки должны быть чем-то заполнены.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (expr[i] == '(' && i != 0 && !IsSgn(expr[i-1]) && expr[i - 1] != '(')
                {
                    MessageBox.Show("Ошибка! Перед откр. скобкой должна стоять операция или откр. скобка.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (expr[i] == ')' && i + 1 != expr.Length && expr[i + 1] != '(' && !IsSgn(expr[i + 1]))
                {
                    MessageBox.Show("Ошибка! После закр. скобки должна стоять операция или закр. скобка.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (IsFunc(save) && expr[i] != 'x' && i + 1 != expr.Length && expr[i + 1] != '(')
                {
                    MessageBox.Show("Ошибка! После имени функции должна стоять откр. скобка.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (IsFunc(save) && expr[i] != 'x' && i - save.Length >= 0 && expr[i - save.Length] != '(' && !IsSgn(expr[i - save.Length]))
                {
                    MessageBox.Show("Ошибка! Перед именем функции должна стоять операция или откр. скобка.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (expr[i] == 'x' && i + 1 != expr.Length && expr[i + 1] != ')' && !IsSgn(expr[i + 1]))
                {
                    MessageBox.Show("Ошибка! После операнда должна стоять операция или закр. скобка.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (expr[i] == 'x' && i != 0 && expr[i-1] != '(' && !IsSgn(expr[i - 1]))
                {
                    MessageBox.Show("Ошибка! Перед операндом доложна стоять операция или откр. скобка.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (IsNumber(save) && i + 1 != expr.Length && !IsSgn(expr[i + 1]) && !IsNumber(expr[i + 1] + "") && expr[i + 1] != ')' && expr[i + 1] != ',')
                {
                    MessageBox.Show("Ошибка! После операнда должна стоять операция или закр. скобка.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else if (IsNumber(save) && i - save.Length >= 0 && !IsSgn(expr[i - save.Length]) && expr[i - save.Length] != '(' && expr[i - save.Length] != ',')
                {
                    MessageBox.Show("Ошибка! Перед операндом доложна стоять операция или откр. скобка.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private bool IsNumber(string str) 
        {
            bool flag = false;
            try
            {
                Convert.ToDouble(str);
                flag = true;
            }
            catch {}
            return flag;
        }
        private bool IsFunc(string str)
        {
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
        private bool IsConst(string str)
        {
            bool flag = false;
            foreach(var item in namesAndConsts)
            {
                if (item.Key.Equals(str)) 
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        private bool IsSgn(char ch)
        {
            if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '^') return true;
            return false;
        }
        private string ExprAdjustment(string expr)
        {
            string save = "";
            string result = "";
            bool flag = false;
            for (int i = 0; i <= expr.Length; i++)
            {
                if (i == expr.Length || expr[i] == '(' || expr[i] == ')' || expr[i] == ',' || IsSgn(expr[i]) || expr[i] == ' ')
                {
                    if (IsConst(save)) result += namesAndConsts[expr[i] + ""];
                    else result += save;
                    save = "";
                    if (i != expr.Length && expr[i] != ' ' && !flag)
                    {
                        result += expr[i];
                        flag = false;
                    }
                }
                else save += expr[i];
            }
            return result;
        }
        public string ExprChangeForParsing()
        {
            return expr;
        }
    }
}
