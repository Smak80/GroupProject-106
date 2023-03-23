using GroupProject_106;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupProject_106
{
    public delegate void Finishdelegate(ExpressionTree tree);
    public class Producer
    {
        public event Finishdelegate? Finish;
        double a;
        double b;
        double dx;
        ExpressionTree tree;
        

        public Producer(double a, double b, double dx , ExpressionTree tree)
        {
            this.tree = tree;
            this.a = a;
            this.b = b;
            this.dx = dx;
        }

        double F(double x)
        {
            return tree.Tarvase(x);
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
            var threadCount = 4;
            var counter = 0;
            for (int tn = 0; tn < threadCount; tn++)
            {
                var t = new Thread(() =>
                {   
                    List<double[]> coordinates = new List<double[]>();
                    double result = 0;
                    for (double i = a + tn * dx; i < b; i += dx * threadCount)
                    {
                        result += F(i) * dx;
                    }
                    CommonData.Put(result);
                    counter++;
                    if (counter == threadCount && Finish != null)
                        Finish(tree);
                });
                t.IsBackground = true;
                t.Start();
            }
        }
    }
}
