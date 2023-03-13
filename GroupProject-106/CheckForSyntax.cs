using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_106
{
    public class CheckForSyntax
    {
        private string expr;
        public CheckForSyntax(string expr) 
        {
            this.expr = expr;   
        }

        public bool ExpressionDiagnostic() 
        {
            return BracketDiagnostic() && WordDiagnostic();
        }
        private bool BracketDiagnostic() 
        {
            return true;
        }
        private bool WordDiagnostic() 
        {
            return true;
        }
    }
}
