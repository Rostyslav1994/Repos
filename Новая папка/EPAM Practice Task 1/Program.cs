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
            Vector first = new EPAM_Practice_Task_1.Vector(2,4,6);
            first.Sum(new EPAM_Practice_Task_1.Vector(2, 4, 5), new EPAM_Practice_Task_1.Vector(5, 4, 8));
            Console.WriteLine(first.Sum(new EPAM_Practice_Task_1.Vector(2, 4, 5), new EPAM_Practice_Task_1.Vector(5, 4, 8)));
            
           

        }
    }
}

