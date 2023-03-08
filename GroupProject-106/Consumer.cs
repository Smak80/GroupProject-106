using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupProject_106
{
    public class Consumer
    {
        static double integral;
        public static double Integral { get => integral; }
        public Consumer()
        {
            integral = 0;
        }

        public void Start(double dx)
        {
            var t = new Thread(() =>
            {
                while (true)
                {
                    var res = CommonData.Get();
                    integral += res;
                }
            });
            t.IsBackground = true;
            t.Start();
        }
        
    }
}
