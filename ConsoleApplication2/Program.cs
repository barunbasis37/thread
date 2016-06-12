using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Start");
            Thread t1 = new Thread(Th1);
            t1.Start();
            Thread t2 = new Thread(Th2);
            t2.Start();

            if (t1.Join(1000))
            {
                Console.WriteLine("T1 Completed");
            }
            else
            {
                Console.WriteLine("T1 is not Completed in 1 sec");
            }
            
            t2.Join();
            Console.WriteLine("T2 Completed");

            for (int i = 0; i < 12; i++)
            {
                if (t1.IsAlive)
                {
                    Console.WriteLine("T1 is still alive");
                }
                else
                {
                    Console.WriteLine("T1 Completed in 2");
                }
            }
            Console.WriteLine("Main Completed");
        }
        public static void Th1()
        {
            Console.WriteLine("Th1 Started");
            Thread.Sleep(5000);
            Console.WriteLine("Th1 is about to return");
        }
        public static void Th2()
        {
            Console.WriteLine("Th2 Started");
        }
    }
}
