using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();
            //Console.Write("Input Your Name : ");
            //var Name = Console.ReadLine();
            //Console.Write("Input Your Age : ");
            //var Age = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("My Name Is " + Name + "\nMy Age Is : " + Age);

            /*
                Console.WriteLine("1 To Plas");
                Console.WriteLine("2 To Minas ");
                Console.WriteLine("3 To Split");
                Console.WriteLine("4 To Mod");
                Console.WriteLine("5 To multiply ");

            var Proccess = "";
            while (Proccess != "0")
            {
                try
                {

                    Console.Write("Input Number One : ");
                    var Num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input Number Two : ");
                    var Num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Input Proccess : ");
                    Proccess = Console.ReadLine();

                    if (Proccess == "1") { Console.WriteLine("Num1 + Num2 : " + Num1 + Num2); }
                    if (Proccess == "2") { Console.WriteLine("Num1 - Num2 : " + (Num1 - Num2)); }
                    if (Proccess == "3") { Console.WriteLine("Num1 / Num2 :" + Convert.ToDouble(Num1) / Convert.ToDouble(Num2)); }
                    if (Proccess == "4") { Console.WriteLine("Num1 % Num2 : " + Num1 % Num2); }
                    if (Proccess == "5") { Console.WriteLine("Num1 * Num2 : " + Num1 * Num2); }
                }
                catch
                {
                    Console.WriteLine("Make Sure Input Type Values");
                }
            }
            */

            //Console.WriteLine(Convert.ToDouble(1)/ Convert.ToDouble(2) + 1 * 5);

            //Console.Write("Input Number One : ");
            //var Num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Input Number Two : ");
            //var Num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(Convert.ToDouble(Num1) / Convert.ToDouble(++Num2) % (1 * 5));


            //Console.WriteLine((-1 + 4) * 6);
            //Console.WriteLine((35 + 5) % 7);

            //Console.WriteLine( Convert.ToDouble((14 - 4) * 6) / Convert.ToDouble(11));

            //Console.WriteLine((((((2+15)/6)*1)-7)%2));

            //Console.Write("Input Number One : ");
            //var Num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Input Number Two : ");
            //var Num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Max Value : " +  Math.Max(Num1,Num2));
            //Console.WriteLine("Min Value : " + Math.Min(Num1, Num2) + "\n");

            //Console.WriteLine("Num1 Sqrt : " + Math.Sqrt(Num1));
            //Console.WriteLine("Num2 Sqrt : " + Math.Sqrt(Num2) + "\n");

            //Console.WriteLine("Num1 Round : " + Math.Round(Num1));
            //Console.WriteLine("Num2 Round : " + Math.Round(Num2) + "\n");

            //Console.WriteLine("Num1 Abs : " + Math.Abs(Num1));
            //Console.WriteLine("Num2 Abs : " + Math.Abs(Num2) + "\n");


            var String1 = "Osama";
            var String2 = "Al-Daja";

            Console.WriteLine(string.Concat(String1,String2));



        }
    }
}
