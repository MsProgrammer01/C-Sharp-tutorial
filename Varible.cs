using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*

               Variables represent our data in memory and  we have a lot of different type of variable
               Knowing the different types of variables is very important because you are dealing with thousands of data 
               and programming is always focused on using the least amount of memory to do the most work to solve problems.
               here we will talk about some of them and in the future we will try to talk about others with different code .
              
             */


            int num1 = 10;                  // ( int ) is the name of the varible , Used to Numerical data.
                                            // It can contain ( -2,147,483,648 to 2,147,483,647 )numbers.  
                                            //It take up 32-bit of memory , and it is a value type .
                                            // and you can not addd point number for int .


            uint num2 = 10;                // ( uint ) is the name of the varible , Used to Numerical data like int .
                                           // It can contain (0 to 4,294,967,295)numbers and you can not add (Negative numbers) for uint.
                                           //It take up 32-bit of memory.
                                           // and you can not add point number for uint .


            sbyte num3 = 127;              // ( sbyte ) is the name of the varible , Used to Small Numerical data.
                                           // It can contain (-128 to 127)numbers.
                                           //It take up 8-bit of memory.
                                           //and you can not add point number for sbyte like 1.2 .


            byte num4 = 44;                // ( byte ) is the name of the varible ,Used to Small Numerical data.
                                           // It can contain (0 to 255 )numbers and you can not add (Negative numbers) for byte .
                                           //It take up 8-bit of memory.
                                           //and you can not add point number for byte.


            short num5 = -120;             // ( short ) is the name of the varible , Used to Numerical data.
                                           // It can contain ( -32,768 to 32,767 )numbers.
                                           //It take up 16-bit of memory.
                                           //and you can not add point number for short .


            ushort num6 = 65535;            // ( ushort ) is the name of the varible ,used to Numerical data.
                                            // It can contain ( 0 to 65,535 )numbers and you can not add (Negative numbers) for ushort .
                                            //It take up 16-bit of memory.
                                            //and you can not add point number for ushort .


            long num7 =-1234567809090090;   // ( long ) is the name of the varible ,used to large Numerical data.
                                            // It can contain ( -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 )numbers .
                                            //It take up 64-bit of memory.
                                            //and you can not add point number for long .

            ulong num8 = 0;                 // ( ulong ) is the name of the varible ,used to large Numerical data.
                                            // It can contain ( 0 to 18,446,744,073,709,551,615 )numbers and you can not add (Negative numbers) for ushort .
                                            //It take up 64-bit of memory.
                                            //and you can not add point number for ulong .



            bool flag = false;             // ( bool ) is the name of the varible.
            bool flage = true;             //We can use booleans for operations that involve comparisons .
                                           //It appears in two ways, either True or False.





            float num9 = 1.2f;              // ( float ) is the name of the varible ,used to  Numerical data.
                                            // It can contain ( -1.5×10^45 to 3.4×10^38 )numbers .
                                            // you can  add point number for float and you can add non point number for float . 
                                            // when you use a point number in float you should to write (f)next to the point nmuber.
                                            //It take up 4-byte of memory.


            double num10 = 2;               // ( double ) is the name of the varible ,used to  Numerical data.
                                            // It can contain ( -1.5×10^45 to 3.4×10^38 )numbers .
                                            // you can  add point number for double and you can add non point number for double. 
                                            //It take up 8-byte of memory.


            decimal num11 = 44.1m;          // ( float ) is the name of the varible ,used to  Numerical data.
                                            // It can contain ( ±1.0×10^-28 to ±7.9×10^28 )numbers .
                                            // you can  add point number for decimal and you can add non point number for float . 
                                            // when you use a point number in decimal you should to write (m)next to the point nmuber.
                                            //It take up 16-byte of memory


            string text1 = "Muhammad";     //(String) you can add every thing inside to  (" ") in string varible
            string text2 = "1234";         // and in the Type-Storage file we talked about string and we said
            string text3 = "True";        // string  is refrence type (predifine)so here actual data is stored in the heap, and the reference is stored on the stack.



            dynamic test_one =122;        // when you test and code in the big application you can use dynamic , var
            var test_two = "Muhammad";     // becauese you can use it evary where without filter of type of number or text
            object test_three = -5;  





            // Declarations varible with example 

            int a = 10;
            Console.WriteLine(a);      //Display varible

            string b = "10";           // (string) is type of vrible  , (b) is the varible name , (10) is the value.
            Console.WriteLine(a + b);  // (b) is the text not a number. 


            ///Multiple Variable Declarations.
            int x, y;
            x = 30;
            y = 20;
            Console.WriteLine(x + y);


                                      


        }
    }
}
