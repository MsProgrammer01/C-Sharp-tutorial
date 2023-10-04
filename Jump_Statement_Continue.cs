using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Jump statement  (Continue) 
            //بەکاردێت بو سنوردارکردن و بەردەوامبونی لە شتێک 






            /*
             لێرەدا ئەو کونتینیویە بەواتای ئەوەدێ ئەو ژمارانەی پێش ژمارە سێن رەن مەکە وە ئەوانی تر رەن بکە 
                                                                                            با جوانتر بیلێین 
                              ئەگەر ئێکس بچوکتر بو لە سێ . کونتنیو واتە رەنی مەکە . وە دوای ئەو دەست پێبکە 
             */


            Console.WriteLine("Example one for Continue");
            for (int x = 0; x < 10; x++)
            {
               

                if (x < 3)
                    continue;
                    Console.WriteLine(x);
                

            }


            
           // لێرەدا دەلێت ئەگەر یەکسانبێت بە سێ تو مەنوسە ژمارە سێ وە بەردەوام بە لە ژمارەکانی تر دا
           

            Console.WriteLine("Example  two for Continue");
            for (int x = 0; x < 10; x++)
            {

                if (x == 3)
                {
                    continue;
                }
                Console.WriteLine(x);
            }




            //واتا بە کورتی ئەوەی پەیوەندی بە مەرجەوە هەبێت جێبەجێ ناکات .وە پازدانی بەسەردا دەکات 


            // بوئەوەی زیاتر فێربی 
            //نموونەی زیاتر تاقیبکەوە


        }
    }
    
}
