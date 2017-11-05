using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle");

            for (int i = 1; i < 7; i++)
            {
                string str = "";
                for (int j = 0; j < i; j++)
                {
                    str += "* ";
                }
                Console.WriteLine(str);
            }

            Console.WriteLine("");

            
            Console.WriteLine("Square");
            for (int i = 0; i < 9; i++)
            {
                string str = "";
                for (int j = 0; j < 8; j++)
                {
                    str += "* ";
                }
                Console.WriteLine(str);
            }

            Console.WriteLine("");

        }
    }
}
