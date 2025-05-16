using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ten counter = new Ten();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();
            counter.Count();
            counter.onCount += handler1.Message;
            counter.onCount += handler2.Message;
            counter.onCount += counter.Message;
            counter.Count();
            Console.ReadKey();
        }
    }
}


 

