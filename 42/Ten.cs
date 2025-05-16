using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42
{
    internal class Ten
    {
       public delegate void CountHandler();
        public event CountHandler onCount; // событие, которое будет вызываться при достижении 7

        public void Count() 
        { 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if ((i == 7)&& (onCount != null))
                {
                    onCount();
                }
            }
        }
        
        public void Message()
        {
            Console.WriteLine("У себя 7!");
        }

    }
}
