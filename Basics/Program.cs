using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Enter the Coffee type");
            Console.WriteLine("pres 1 for small");
            Console.WriteLine("pres 2 for medium");
            Console.WriteLine("pres 3 for large");
            int Choice = int.Parse(Console.ReadLine());
            int Total_Bill = 0;


            switch (Choice)
            {
                case 1:

                    Total_Bill = +10;

                    break;

                case 2:

                    Total_Bill = +20;


                    break;

                case 3:
                    Total_Bill = +30;

                    break;

                default:
                    Console.WriteLine("Please select coffee type");
                    Console.ReadLine();

                    break;
            }

            Console.WriteLine("Your Total Bill is ={0}", Total_Bill);
            Console.ReadLine();

            Console.WriteLine("Do you place another order");
            string Another_Order = Console.ReadLine();

            switch (Another_Order)
            {

                case "Yes":

                    goto start;

                case "No":

                    Console.WriteLine("Thanks for your Visit");
                    Console.ReadLine();
                    break;

                default:

                    Console.WriteLine("Choice is invalid. Try again");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
