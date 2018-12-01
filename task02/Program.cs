using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Company cmp = new Company(5);

            Console.WriteLine(cmp[4]);

            Console.ReadKey();
        }
    }
}
