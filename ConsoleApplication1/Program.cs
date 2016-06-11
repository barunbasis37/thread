using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate void SumOfNumbersCallBack(int SumOfNumbers);
    class Program
    {
        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum of numbers = " + sum);
        }
        public static void Main(string[] args)
        {
            
            //Thread t=new Thread(aNumber.PrintNumber);
            //t.Start();

            Console.WriteLine("Please Write number");
            int target = Convert.ToInt32(Console.ReadLine());
            SumOfNumbersCallBack callback = new SumOfNumbersCallBack(PrintSum);

            Number aNumber = new Number(target, callback);
            Thread tParameter=new Thread(aNumber.PrintSumNumber);
            tParameter.Start();

        }
    }

    class Number
    {
        int _target;
        private SumOfNumbersCallBack _callBack;

        public Number(int target, SumOfNumbersCallBack callBack)
        {
            this._target = target;
            this._callBack = callBack;
        }
        public  void PrintSumNumber()
        {
            int sum = 0;
            //if (int.TryParse(target.ToString(),out number))
            //{
                for (int i = 0; i <= _target; i++)
                {
                    sum = sum + i;
                }
            //}
            if (_callBack != null)
            {
                _callBack(sum);
            }

        }
    }
}
