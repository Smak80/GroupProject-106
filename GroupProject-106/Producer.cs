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
    public delegate void Finishdelegate();
    public delegate void Drawdelegate(List<double[]> coordinates);
    public class Producer
    {
        public event Finishdelegate? Finish;
        public event Drawdelegate? Draw;
        double a;
        double b;
        double dx;
        ExprTree tree;
        

        public Producer(double a, double b, double dx , ExprTree tree)
        {
            this.tree = tree;
            this.a = a;
            this.b = b;
            this.dx = dx;
        }

        double F(double x)
        {
            return tree.ExprTreeTarvase(tree.Root, x); 
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
            var threadCount = 1;
            var counter = 0;
            var threadcounter = 0;
            for (int tn = 0; tn < threadCount; tn++)
            {
                var t = new Thread(() =>
                {   
                    List<double[]> coordinates = new List<double[]>();
                    double result = 0;
                    for (double i = a; i <= b; i += dx * threadCount)
                    {
                        double[] coord = new double[] { i, F(i) };
                        coordinates.Add(coord);
                    }
                    threadcounter++;
                    if ( Draw != null)
                        Draw(coordinates);
                    foreach (var coord in coordinates)
                    {
                        result += coord[1] * dx;
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
