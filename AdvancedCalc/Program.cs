using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------WElCOME TO THE ADVANCED CALCULATOR -------");
            Console.WriteLine("------------Made By Er.Saroj Shrestha------------\n");
            Calc();
            Console.ReadLine();
        }

        static void Calc()
        {
            
            bool cont = true;
            try
            {
                while (cont)
                {
                    Console.Write("\nEnter first number: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nEnter second number: ");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\n1. Add 2.Subtract 3.Division 4.Multiplication 5.Power");
                    Console.WriteLine("Enter your choice: ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    double result;
                    switch (c)
                    {

                        case 1:
                            result = x + y;
                            Console.WriteLine("The output is: " + result);
                            break;

                        case 2:
                            result = x - y;
                            Console.WriteLine("The output is: " + result);
                            break;

                        case 3:
                            result = x / y;
                            Console.WriteLine("The output is: " + result);
                            break;

                        case 4:
                            result = x * y;
                            Console.WriteLine("The output is: " + result);
                            break;

                        case 5:
                            result = Math.Pow(x, y);
                            Console.WriteLine("The output is: " + result);
                            break;

                        default:

                            Console.WriteLine("Error!!!!! Invalid Option.");
                            break;


                    }
                    Console.WriteLine("Do you want to continue? Pres \"1\" to continue. \"2\"to Exit ");
                    int loop = Convert.ToInt32(Console.ReadLine());
                    if (loop == 1)
                    {
                        cont = true;
                    }
                    else if (loop == 2)
                    {
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option");
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Calc();

            }
        }
    }
}
