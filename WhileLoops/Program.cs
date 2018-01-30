using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");

            int User_Numer = int.Parse(Console.ReadLine());
            Console.ReadLine();
            int Number = 0;
            while (Number < User_Numer)
            {
                Number = Number + 1;

                Console.WriteLine("Number are ={0}", Number);
                Console.ReadLine();

            }
        }
    }
}
