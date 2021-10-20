using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
        class Program
        {

        static void Main()
        {
            int n, a = 0, b = 1, c, i;
            Console.Write("Enter the number of terms : ");
            n = Int32.Parse(Console.ReadLine());
            for (i = 0; i &lt; n; i++)
            {
                if (i &lt;= 1)
                    c = i;
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.Write(c+"  ");
            }
            Console.ReadKey();
        }
    }
    
}
