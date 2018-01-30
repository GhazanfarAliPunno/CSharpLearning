using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[5];
            Numbers[0] = 100;
            Numbers[1] = 200;
            Numbers[2] = 300;
            Numbers[3] = 400;
            foreach (int values in Numbers)
            {

                Console.WriteLine(values);
                Console.ReadLine();
            }





        }
    }
}
