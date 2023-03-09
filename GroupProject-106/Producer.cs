using GroupProject_106;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupProject_106
{
    public delegate void Finishdelegate();
    public class Producer
    {
        public event Finishdelegate? Finish;
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
            /*
            1 - 2757
            2 - 1703
            3 - 1273
            4 - 1089

             */
            object locker = new object();
            var threadCount = 5;
            var counter = 0;
            for (int tn = 0; tn < threadCount; tn++)
            {
                var t = new Thread(() =>
                {
                    double result = 0;
                    for (double i = a; i <= b; i += dx * threadCount)
                    {
                        result += Form1.F(i) * dx;
                    }
                    CommonData.Put(result);
                    counter++;
                    if (counter == threadCount && Finish != null) Finish();
                });
                t.IsBackground = true;
                t.Start();
            }
        }
    }
}
