using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is a count from 1 - 99 -- odd numbers only");

            int count;
            for (count = 1; count <= 99; count += 2)

            {
                Console.WriteLine(count);
            }
                Console.ReadLine();

        }
    }
}
