using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_W8_Toby_Bly
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 9; n += 2)
            {
                Console.WriteLine(n);
            }

            for (int n = 30; n <= 45; n++)
            {
                if ((n % 2) == 0) // it's even
                    Console.WriteLine(n + ", ");
               
                   
            }

            for (int n = 30; n <= 45; n++)
            {
                if ((n % 2) == 1) // it's odd
                    Console.WriteLine(n + ", ");
            }

            int i = 10;
            while (i < 21)
            {
                Console.WriteLine(i);
                i++;
            }

            for (int p = 0; p < 101; p++)
            {
                Console.WriteLine(p);
                Console.WriteLine("********");
            }

        }

        


    }
}
