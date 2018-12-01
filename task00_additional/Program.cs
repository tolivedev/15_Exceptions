using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task00_additional
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            try
            {
                Console.WriteLine("Введите операнд 1 ");
                string operand1 = Console.ReadLine();
                Console.WriteLine("Введите операнд 2 ");
                string operand2 = Console.ReadLine();
                int a = string.IsNullOrEmpty(operand1) ? 0 : Convert.ToInt32(operand1);
                int b = string.IsNullOrEmpty(operand2) ? 0 : Convert.ToInt32(operand2);
                Console.WriteLine("Выберите один оператор '+ - * /' ");
                char switcher = Console.ReadLine().ToCharArray()[0];

                switch (switcher)
                {
                    case '+': { calc.Add(a, b); break; }
                    case '-': { calc.Sub(a, b); break; }
                    case '*': { calc.Mul(a, b); break; }
                    case '/': { calc.Div(a, b); break; }

                    default:
                        {
                            Console.WriteLine("Введён неверный символ. Ввыберите один из '+ - * /'");
                            break;
                        }
                }
                //
            }
            catch (Exception ariphEx)
            {
                Console.WriteLine("Возникло следующее: {0}", ariphEx.Message);
            }
            Console.ReadKey();
        }
    }
}
