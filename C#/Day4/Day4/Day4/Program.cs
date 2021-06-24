using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 1;i<=1000;i++)
            //{

            //    if (i%7 == 0)
            //    {
            //        Console.WriteLine(i + " / 7 = " + i/7);
            //    }

            //    if (i % 2 == 0) { Console.WriteLine("Even Number : " + i); }

            //    Console.WriteLine("\n\n");
            //}


            //Console.WriteLine("*** Input 0 To Stop *** \n\n");

            //Console.Write("Input X Value : ");
            //var X = Convert.ToDouble(Console.ReadLine());

            //while (X !=0)
            //{
            //    Console.WriteLine("square ({0}) = " +  Math.Pow(X,2) + ", Sqrt({0}) = " +  Math.Sqrt(X) + "\n" , X);

            //    Console.WriteLine("\n*** Input 0 To Stop ***\n\n");
            //    Console.Write("Input X Value : ");
            //    X = Convert.ToDouble(Console.ReadLine());
            //}

            //Console.WriteLine("\n*** Input 0 To Stop ***\n\n");
            //Console.Write("Input X Value : ");
            //var X = Convert.ToDouble(Console.ReadLine());





            //double X = new double();

            //do
            //{


            //    Console.WriteLine("square ({0}) = " + Math.Pow(X, 2) + ", Sqrt({0}) = " + Math.Sqrt(X) + "\n", X);

            //    Console.WriteLine("\n*** Input 0 To Stop ***\n\n");
            //    Console.Write("Input X Value : ");
            //    X = Convert.ToDouble(Console.ReadLine());

            //} while (X != 0);


            //Console.WriteLine("***** Start For Loop *****");
            //for(int i = 10; i <=20; i+=2)
            //{
            //    if(i == 16) { continue; }
            //    Console.WriteLine("I In Loop Is : " + i);
            //}


            var Count = 0;
            Console.Write("Input Count Of Values : ");
            Count = Convert.ToInt32(Console.ReadLine());

            int[] ArraryOfInt= new int [Count];


            for(int i = 0; i < Count;i++)
            {
                Console.Write("Input Your Value : ");
                ArraryOfInt[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\n\n\n**** Display *****\n\n");

            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("Your Value Number ({0}) : "+ ArraryOfInt[i], i+1);
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
