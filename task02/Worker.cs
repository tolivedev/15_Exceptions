using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    enum Enums : int
    {
        A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z
    }
    class YearExceprion : Exception
    {
        public void ThrowExc()
        {
            this.HelpLink = "http://google.ru";
            this.Data.Add("Причина исключения", "Несоответствие длины параметра.Меньше 50ти лет от текущего или больше текущего");
            this.Data.Add("Время возникновения", DateTime.Now);
            throw this;
        }

    }

    struct Worker : IComparable<Worker>
    {
        public string Fio { get; set; }
        public string Position { get; set; } //должность
        private int yearEmployees;

        public int YearEmployees
        {
            get { return yearEmployees; }
            set
            {
                //try
                {
                    if (DateTime.Now.Year - 50 < value && value < DateTime.Now.Year)
                    {
                        yearEmployees = value;
                    }
                    else new YearExceprion().ThrowExc();
                }
                //catch (YearExceprion e)
                {
                    //Console.WriteLine("Несоответствие длины параметра/не попадает в интервал меньше 1970 или больше текущего. {0}", e.Message);
                    //throw;
                }
            }
        }
        
        public int CompareTo(Worker other)
        {
            object element = Enum.Parse(typeof(Enums), this.Fio[0].ToString());
            object externalElement = Enum.Parse(typeof(Enums), other.Fio[0].ToString());
            if ((int)element < (int)externalElement)
                return -1;
            else if ((int)element > (int)externalElement)
                return 1;
            else return 0;
        }
        //else throw new Exception("Объект должен быть типа Article");

        public int Experience()
        {
            var a = Math.Abs(yearEmployees - DateTime.Now.Year);
            return a;
        }
    }
}
