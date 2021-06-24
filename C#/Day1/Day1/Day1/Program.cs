using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo \nOsama AL-Daja \n");

            Console.WriteLine("Hallo");
            Console.WriteLine("Osama AL-Daja");

            dynamic dynamicValue;
            dynamicValue = "Name";
            Console.WriteLine(dynamicValue);
            dynamicValue = 1.1;
            Console.WriteLine(dynamicValue);
            dynamicValue = DateTime.Now;
            Console.WriteLine(dynamicValue);
            if(dynamicValue == DateTime.Now)
            {
                Console.WriteLine("True");
            }else
            {
                Console.WriteLine("False");
            }

            object objectValue;
            objectValue = "Name";
            Console.WriteLine(objectValue);
            objectValue = 1.1;
            Console.WriteLine(objectValue);
            objectValue = DateTime.Now;
            Console.WriteLine(objectValue);

            //Error
            //if (objectValue == DateTime.Now)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
        }
    }
}
