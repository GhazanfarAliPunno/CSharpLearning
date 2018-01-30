using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTableWithLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int result = 0;
            Console.WriteLine("Enter the number for required table");
            int Input_Number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                result = Input_Number * i;
                Console.WriteLine(result);
                Console.ReadLine();



            }
        }
    }
}
