using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        public int Met(int m)
        {
            Dictionary<int, int> bank = new Dictionary<int, int>();
            bank.Add(10, 80);
            bank.Add(20, 50);
            bank.Add(100, 30);
            bank.Add(200, 25);
            bank.Add(500, 10);
            int sum = 0;
            int countv = 0;
            int countk = 0;
            int countvalue = 0;
            foreach (KeyValuePair<int, int> pair in bank) // verify the sums
            {
                sum += pair.Key * pair.Value;
            }
            if (sum < m)
            {
                return -1;
            }
            else
            {
                bank.Reverse(); // Revers of the bank
                foreach (KeyValuePair<int, int> item in bank.Reverse()) // checking operation 
                {
                    if (m < item.Key) { }
                    else
                    {
                        countvalue = item.Value;
                        while (m >= item.Key && countvalue  != 0)
                        {
                            countk = item.Key;
                            countv++;
                            m = m - item.Key;
                            countvalue--;

                        }
                        Console.WriteLine(countk + " grn \t" + countv + " st.");
                        countk = 0;
                        countv = 0;
                    }
                }
            }
            return m;
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine(a.Met(7502));
        }
    }
}
