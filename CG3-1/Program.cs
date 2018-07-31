using System;

namespace CG3_1
{
    class Program
    {
        

        static void Main(string[] args)
        {
           //Here is where the user is asked to input a number 
            Console.WriteLine("Enter a number 1-12: ");
            //Here is where "Month" is defined(? is that the correct term here?)
            string Month = Console.ReadLine();

            //The first if statement
            if (Month == "1")
            {
                Console.WriteLine("January");
                Console.Read();           
            }
            //else if, for any other accepted value other than 1. For 2-12, I used copy paste, and edited in the correct number/month.
            else if (Month == "2")
            {
                Console.WriteLine("February");
                Console.Read();
            }
            else if (Month == "3")
            {
                Console.WriteLine("March");
                Console.Read();
            }

            else if (Month == "4")
            {
                Console.WriteLine("April");
                Console.Read();
            }
            else if (Month == "5")
            {
                Console.WriteLine("May");
                Console.Read();
            }
            else if (Month == "6")
            {
                Console.WriteLine("June");
                Console.Read();
            }
            else if (Month == "7")
            {
                Console.WriteLine("July");
                Console.Read();
            }
            else if (Month == "8")
            {
                Console.WriteLine("August");
                Console.Read();
            }
            else if (Month == "9")
            {
                Console.WriteLine("September");
                Console.Read();
            }
            else if (Month == "10")
            {
                Console.WriteLine("October");
                Console.Read();
            }
            else if (Month == "11")
            {
                Console.WriteLine("November");
                Console.Read();
            }
            else if (Month == "12")
            {
                Console.WriteLine("December");
                Console.Read();
            }
            else //Here is what will print if a value other than 1-12 is entered.
            {
                Console.WriteLine("Unknown value");
                Console.ReadLine();

            }




        }
    }
}
