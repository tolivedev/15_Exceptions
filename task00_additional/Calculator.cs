using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task00_additional
{
    class Calculator
    {
        public void Add(int a, int b) => Console.WriteLine( a + b);
        public void Sub(int a, int b) => Console.WriteLine(a - b);
        public void Mul(int a, int b) => Console.WriteLine(a * b);
        public void Div(int a, int b)
        {
           // try
            {
                Console.WriteLine("Результат деления : {0}", a / b);
            }
            //catch (DivideByZeroException divEx)
            {
                //Console.WriteLine("Упс! - {0}"), divEx.Message);
               //throw divEx;
            }
            //finally
            { //continue
            }
        }
    }
}
