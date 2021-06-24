using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Process = new char();
            var Num1 = new double();
            var Num2 = new double();

            try
            {
                Console.Write("Input Number One : ");
                Num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input Number Two : ");
                Num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input Process Character : ");
                Process = Convert.ToChar(Console.ReadLine());

                if (Process == '+') { Console.WriteLine("Sumation (" + Num1 + " + " + Num2 + ") = " + (Num1 + Num2) + "\n"); }
                else
                {
                    switch (Process)
                    {
                        case '*':
                            {
                                Console.WriteLine("Multiplication (" + Num1 + " * " + Num2 + ") = " + (Num1 * Num2) + "\n");
                                break;
                            }
                        case '/':
                            {
                                Console.WriteLine("Dividation (" + Num1 + " / " + Num2 + ") = " + (Num1 / Num2) + "\n");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine(Process == '-' ? "Subtraction (" + Num1 + " - " + Num2 + ") = " + (Num1 - Num2) + "\n" : "Character Is Undefined" + "\n");
                                break;
                            }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Make Sure Inputs Values");
            }

            Console.Write("\n\n\n");
            Console.WriteLine("*** While Loop ***");
            Console.Write("\n\n\n");
            //With Loop
            Console.WriteLine("Input C To Stop Loop ...");
            Console.Write("\n");

            while (Process != 'C')
            {
                try
                {
                    Console.Write("Input Number One : ");
                    Num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Input Number Two : ");
                    Num2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Input Process Character : ");
                    Process = Convert.ToChar(Console.ReadLine());

                    if (Process == '+') { Console.WriteLine("Sumation ("+Num1+ " + "+Num2+") = " + (Num1 + Num2) + "\n"); }
                    else
                    {
                        switch (Process)
                        {
                            case '*':
                                {
                                    Console.WriteLine("Multiplication (" + Num1 + " * " + Num2 + ") = " + (Num1 * Num2) + "\n");
                                    break;
                                }
                            case '/':
                                {
                                    Console.WriteLine("Dividation (" + Num1 + " / " + Num2 + ") = " + (Num1 / Num2) + "\n");
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine(Process == '-' ? "Subtraction (" + Num1 + " - " + Num2 + ") = " + (Num1 - Num2) + "\n" : "Character Is Undefined" + "\n");
                                    break;
                                }
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Make Sure Inputs Values");
                }
            }


        }
    }
}
