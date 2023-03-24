using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.PrimeNumbersRange
{
    public class PrimeRange
    {
        public void PrimeNumbers()
        {           
            for (int i = 0; i < 1000; i++)
            {
                int count = 0;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i%j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && i != 1)
                    Console.WriteLine("{0} is Prime number", i);
            }
        }
    }
}
