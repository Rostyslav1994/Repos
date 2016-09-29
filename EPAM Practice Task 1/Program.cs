using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_Practice_Task_1
{
    class Program
    {
        static void Main()
        {
            Vector first = new Vector();
            foreach (var v in first.Sum(first.a, first.b))
            {
                Console.WriteLine("Vect c = {0}", v); ;
                Console.WriteLine("Dzebas");
            }
        }
    }
}

