using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupProject_106
{
    public static class CommonData
    {
        public static Queue<double> data = new Queue<double>();
        
        static object locker = new object();

        public static void Put(double elem)
        {
            lock (locker)
            {
                data.Enqueue(elem);
                Monitor.PulseAll(locker);
            }
        }
        public static double Get()
        {
            lock (locker)
            {
                while (data.Count <= 0)
                {
                    Monitor.Wait(locker);
                }
                var res = data.Dequeue();
                
                return res;
            }
        }
    }
}
