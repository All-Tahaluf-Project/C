using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class Program
    {

        //Q1 :
        //static double MinimumValue(double [] ArrayOfStudent)
        //{
        //    return ArrayOfStudent.Min();
        //}

        //static double MaximumValue(double[] ArrayOfStudent)
        //{
        //    return ArrayOfStudent.Max();
        //}

        //static double Average(double[] ArrayOfStudent)
        //{
        //    return ArrayOfStudent.Average();
        //}

        //static double AboveAverage(double[] ArrayOfStudent,double AVG)
        //{
        //    return ArrayOfStudent.Where(a => a > AVG).Count();
        //}

        //static double BelowAverage(double[] ArrayOfStudent, double AVG)
        //{
        //    return ArrayOfStudent.Where(a => a < AVG).Count();
        //}

        //static void Main(string[] args)
        //{
        //    try
        //    {

        //        Console.WriteLine("Hallo Teacher.");
        //        Console.Write("Input Number Of Student Please : ");
        //        var NumberOfStudent = Convert.ToInt32(Console.ReadLine());
        //        var ArrayOfStudent = new double[NumberOfStudent];

        //        double GPA = 1;

        //        for (int i = 0; i <= NumberOfStudent-1; i++)
        //        {
        //            Console.Write("Input GPA For Student Number {0} : " ,i+1);
        //            GPA = Convert.ToDouble(Console.ReadLine());
        //            ArrayOfStudent[i] = GPA;
        //        }

        //        var AVG = Average(ArrayOfStudent);
        //        Console.WriteLine("\n\n\n\n\n********** ^_^ **********\n");
        //        Console.WriteLine("\nMinimum Value : " + MinimumValue(ArrayOfStudent));
        //        Console.WriteLine("\nMaximum Value : " + MaximumValue(ArrayOfStudent));
        //        Console.WriteLine("\nAverage Value : " + AVG);
        //        Console.WriteLine("\nNumber Of Students Are Above The Average : " + AboveAverage(ArrayOfStudent,AVG));
        //        Console.WriteLine("\nNumber Of Students Are Below The Average : " + BelowAverage(ArrayOfStudent, AVG));
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Make Sure Input True Type Of Value");
        //    }
        //}


        //Q2 : 


        static void Display(List<string> ListMealInvoice,double TotalInvoice)
        {
            Console.WriteLine("\n\n\n\n\n********** Invoice **********\n\n");
            foreach (var Meal in ListMealInvoice)
            {
                Console.WriteLine(Meal);
            }
            Console.WriteLine("\n\nTotal Invoice : " + TotalInvoice + "\n\n\n");
        }

        static string DisplayListMeal(string[] ListMeal,double[] ListPrice)
        {
            string Text = "";
            for (int i = 1; i < ListMeal.Length; i++)
            {
                Text += "\n" + i + " -) Meal : " + ListMeal[i] + ", Price : " + ListPrice[i];
            };

            return Text;
        }

        static void Main(string[] args)
        {

            var ListMeal = new string[] {"", "Seafood Soup", "Pizza big", "Chicken BBQ", "Falafel" , "Hummus" , "Fresh Juice" , "Seafood Salad" , "Nachos" , "Fried fish" , "Beef With Vegetables"};
            var ListPrice = new double[] { 0 ,6, 6, 12, 2 , 2.75 , 3 , 7.75 , 7 , 9 , 9.5,};

            List<string> ListMealInvoice = new List<string>();

            Console.WriteLine(DisplayListMeal(ListMeal, ListPrice));

            int Processe = 0;
            var TotalInvoice = 0.0;

            try
            {
                Console.Write("Number Of Meal : ");

                Processe = Convert.ToInt32(Console.ReadLine());
            }catch
            {
                Console.WriteLine("\n\nError");
                Console.WriteLine("Make Sure Types Of Values");
            }

            while (Processe != 0)
            {
                try
                {
                    TotalInvoice += ListPrice[Processe];

                    ListMealInvoice.Add(Processe + " -) Meal : " + ListMeal[Processe] + ", Price : " + ListPrice[Processe]);

                    Console.WriteLine("\n\n***** Input 0 To Take Invoice *****");
                    Console.WriteLine(DisplayListMeal(ListMeal, ListPrice));

                    Console.Write("Number Of Meal : ");
                    Processe = Convert.ToInt32(Console.ReadLine());
                }catch
                {
                    Processe = 0;
                    Console.WriteLine("\n\nError");
                    Console.WriteLine("Make Sure Types Of Values");
                }
            }

            Display(ListMealInvoice, TotalInvoice);
        }
    }
}
