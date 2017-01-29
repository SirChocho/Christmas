using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace christmas
{
    class christmas
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var star = n * 4 + 1;
            var inner = 0;
            var outer = n * 2 - 1;

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("{0}/|\\{0}", new string ('.',outer));

            }
            for(int i = 0; i < 1; i++)
            {
                Console.WriteLine("{0}\\|/{0}", new string('.', outer));

            }

            for (int i = 0; i < n*2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outer), new string('-', inner));
                outer -= 1;
                inner += 1;
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(new string('*', n*4+1));
            }
            for (int i = 0; i < n*2; i++)
            {
                Console.Write("*.");

            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("*");
            }

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(new string('*', n * 4 + 1));
            }


        }
    }
}
