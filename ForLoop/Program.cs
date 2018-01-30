using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Number");
            int User_Numer = int.Parse(Console.ReadLine());
            Console.ReadLine();
                        for (int i = 1; i < User_Numer; i++)
            {
                Console.WriteLine("Number are ={0}", i);
                Console.ReadLine();

            }
        }
    }
}
