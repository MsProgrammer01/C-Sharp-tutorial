using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // interpolation string 
            int x = 10;
            int y = 20;
            Console.WriteLine($"X = {x} , Y = {y}");



            int a = 10;
            int b = 20;
            Console.WriteLine(" A = {0} , B = {1}", a, b);
            Console.WriteLine(" A = {0} , B = {1} and A ={0}", a, b);


            int c = 10;
            int d = 20;
            Console.WriteLine("C = " + c + " D = " + d);

            Console.WriteLine("Sell it for {0:C}", 300);    //change number to Currency 
            Console.WriteLine("The value: {0:f4}", 12.3001233);  // four number after point  or Fixed point
            Console.WriteLine("The value: {0:G4}", 12.3061233);  // Two number after point  or General  number
            Console.WriteLine("The value: {0:P2}", 12.3061233);  // change number to percent
            Console.WriteLine("{0, 5}", 300);    // {0,5} means 5 Space

        }
    }
}
