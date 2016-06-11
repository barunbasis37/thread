using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Thread t=new Thread(aNumber.PrintNumber);
            //t.Start();

            Console.WriteLine("Please Write number");
            int target = Convert.ToInt32(Console.ReadLine());
            Number aNumber = new Number(target);
            Thread tParameter=new Thread(aNumber.PrintParameterNumber);
            tParameter.Start();

        }
    }

    class Number
    {
        int _target;

        public Number(int target)
        {
            this._target = target;
        }
        public  void PrintParameterNumber()
        {
            //int number = 0;
            //if (int.TryParse(target.ToString(),out number))
            //{
                for (int i = 0; i <= _target; i++)
                {
                    Console.WriteLine(i);
                }
            //}

        }
    }
}
