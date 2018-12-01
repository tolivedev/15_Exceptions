using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskExample
{
    enum Enums : int
    {
        A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z
    }

    struct Worker: IComparable<Worker>
    {
        public string fio;
        string position;
        int yearEmployees;
        public string enumst;

        public int CompareTo(Worker other)
        {
            object element = Enum.Parse(typeof(Enums), this.fio[0].ToString());
            object externalElement = Enum.Parse(typeof(Enums), other.fio[0].ToString());
            if ((int)element < (int)externalElement)
                return -1;
            else if ((int)element > (int)externalElement)
                return 1;
            else return 0;
        }

    }
#if false
    class Program
    {
        static void Main(string[] args)
        {
            Worker wrk = new Worker();
            wrk.fio = "Avanov0";
            Worker wrk1 = new Worker();
            wrk1.fio = "Aavaria";
            if (wrk.fio[0] < wrk1.fio[0])
            {

            }
            Console.WriteLine(new string('+', 50));
            for (int i = 0; i < 26; i++)
            {

            }
            Console.ReadKey();
        }
    }


    enum EnumType
    {
        Zero,  // = 0 
        One = 1,
        one = One,
        Two = 2,
        Three, // = 3
        Four,  // = 4
        Five = 5,
        //Six,
        Seven,
        Eight = 8,
        Nine,
        Ten = 10,
        Infinite = 255
    }
#endif
    class Program
    {
        static void Main()
        {
            Worker wrk1 = new Worker();
            Worker wrk2 = new Worker();
            wrk1.fio = "Cltr";
            wrk2.fio = "Alc";

            //Enums element = wrk1.fio[0];  так делать нельзя
            //object element = Enum.Parse(typeof(Enums), wrk1.fio[0].ToString());
            object externalElement = Enum.Parse(typeof(Enums), wrk2.fio[0].ToString());
            Console.WriteLine("wrk1 {0}, wrk2 {1}", (int)element,(int)externalElement);
            // Delay.
            Console.ReadKey();
        }
    }

}
