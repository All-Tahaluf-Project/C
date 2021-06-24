using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Palyer In My Game ...");
            Console.WriteLine("Are You can Guessed My Number of Game ...");
            Console.WriteLine("Number Sould Be More Than 50 And Less Than 75 ...");
            Console.WriteLine("********** Let's Play ********** \n\n\n\n\n");

            var RandomNumber = new Random().Next(50, 76);
            int CountTry = 0;
            int MyNumber = 0;

            try
            {
                Console.Write("Input Number (50 To 75) : ");
                MyNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\n");
                CountTry++;
            }
            catch
            {
                Console.WriteLine("Make Sure Type Of Value");
            }

            while (MyNumber != RandomNumber)
            {
                try
                {
                    Console.WriteLine("*_* ********** Try Again ********** *_*");
                    Console.Write("Input Number (50 To 75) : ");
                    MyNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n\n");
                    CountTry++;
                }
                catch
                {
                    Console.WriteLine("Make Sure Type Of Value, Shoud Be Integer Number.");
                }
            }

            switch (CountTry)
            {
                case 1:
                    {
                        Console.WriteLine("\n\n ^_^ ********** You Win ********** ^_^");
                        Console.WriteLine("10 Points Of 10 Points");
                        Console.WriteLine("You Try {0} Of Times ", CountTry);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\n\n ^_^ ********** You Win ********** ^_^");
                        Console.WriteLine("7 Points Of 10 Points");
                        Console.WriteLine("You Try {0} Of Times ", CountTry);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\n\n ^_^ ********** You Win ********** ^_^");
                        Console.WriteLine("5 Points Of 10 Points");
                        Console.WriteLine("You Try {0} Of Times ", CountTry);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\n\n ^_^ ********** You Win ********** ^_^");
                        Console.WriteLine("3 Points Of 10 Points");
                        Console.WriteLine("You Try {0} Of Times ", CountTry);
                        break;
                    }
            }

        }
    }
}
