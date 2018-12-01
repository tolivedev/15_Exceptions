using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    class Company
    {
        Worker[] wrk = null;
        public Company(int count)
        {
            int a = 0;
            // Worker[]  = new Worker[5];// { fio = Console.ReadLine() };
            wrk = new Worker[count];
            for (int i = a; i < count; i++)
            {
                M:
                try
                {
                    Console.WriteLine("Введите {0}-го wroker'а\n", i);
                    wrk[i] = new Worker { Fio = Console.ReadLine(), Position = Console.ReadLine(), YearEmployees = Convert.ToInt32(Console.ReadLine()) };
                    Console.WriteLine("\nAdd complete {0}!\n", i);
                    a++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //throw;
                    goto M;
                }
            }
            // Array.Sort(wrk);

            //первый параметр расширяющий, вызывается на IEnumerable объекте или производном от него
            //второй параметр идёт в качестве аргумента метода OrderBy - делегат Func,являет собой значение ключа, по которому будет сортировка
            wrk = wrk.OrderBy(worker=>worker.Fio).ToArray(); 
        }
        public string this[int index]
        {
            get
            {
                string response = "";
                for (int i = 0; i < wrk.Length; i++)
                {
                    if (index < Math.Abs(wrk[i].YearEmployees - DateTime.Now.Year))
                    {
                        response += ("Стаж работы " + wrk[i].Experience().ToString() + " лет для сотрудника: " + wrk[i].Fio + "\n");  /* return the specified index here */
                    }
                }
                if (response.Length > 0)
                {
                    return response;
                }
                return $"Нет сотрудника со стажем {index}";
                //throw new IndexOutOfRangeException();
            }

            private set { throw new IndexOutOfRangeException(); }
        }
    }
}

