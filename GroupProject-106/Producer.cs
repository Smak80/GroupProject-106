using GroupProject_106;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupProject_106
{
    public class Producer
    {
        double a;
        double b;
        double dx;
        public Producer(double a, double b, double dx)
        {
            this.a = a;
            this.b = b;
            this.dx = dx;
        }

        public void Start()
        {
            object locker = new object();
            var threadCount = 3;
            for (int tn = 0; tn < threadCount; tn++)
            {
                var t = new Thread(() =>
                {
                    double result = 0;
                    for (double i = a; i <= b; i += dx * threadCount)
                    {
                        result += Program.F(i) * dx;
                    }
                    CommonData.Put(result);
                });
                t.IsBackground = true;
                t.Start();
            }
        }
    }
}
