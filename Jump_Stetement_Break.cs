using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Jump statement  (break) 
            //بەکاردێت بو سنوردانان بو کارێک
            //برێک واتە وەستانی کردار بەتەواوی





            /*
                             لێرەدا نموونەی یێکەمدا فور لوپەکە رەن دەبێت هەتا وەکو دەگاتە ژمارە سێ 
            وە چونکە کونسول لەپێش مەرجەکە نوسراوە کەواتە ژمارە سێش رەن دەبێت ئەوجا برێک کاری خوی دەکات
                                      کە دەلێت ئەگەر هاتوو فورلوپ یێکسانبوو بە سێ ، بەرنامەکە بوەستێنە    
             */

            Console.WriteLine("Example one for break");
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(x);    

                if (x == 3)
                {
    
                    break;
                }
               
            }



            /*
                      لە نموونەی دوەمدا فور لوپەکە رەن دەبێت بەلام نانوسرێن ژمارە 
            چونکە کونسول لەناو یفە وە دەبێت مەرجی یف بەجێبێت تاوەکو ژمارە بنوسرێن 
                                وە لێرەدا هەرکە ژمارە سێ هات وە مەرجەکە راست بوو 
                 راستەوخوو کونسول کاردەکات و برێک دەبێت وە ناگەرێتەوە نێو فورلوپ 
             */

            Console.WriteLine("Example two for break");
            for (int x = 0; x < 10; x++)
            {
                
                if (x == 3)
                {
                    Console.WriteLine(x);
                    break;
                 
                }

            }




            /*
                لە نمونەنەی سێیەمدا ژمارەکان دەنوسرێن چونکە لە دەرەوەی یفەکەدان هەتا وەکو دەگەنە ژمارە سێ
                                        . بەلام ژمارە سێ نانوسرێن چونکە لەنێو یفەکەدا کونسول نەنوسراوە 
                                             وە بەهوی برێکەوە نەتوانێت بێتە خوارەوە بو رەنبونی ژمارە سێ
             */

            Console.WriteLine("Example three for break");
            for (int x = 0; x < 10; x++)
            {

                if (x == 3)
                {              
                    break;
                }
                Console.WriteLine(x);
            }




            //ئەوەش هەر نموونەیەکی ئاسای سویچ کەیسە کە رێک تیا بەکارهاتووە
            //لێرەدا دەلێین دەتوانین برێک لە شوێنی جیاواز بەکاربێنین 

            Console.WriteLine("Example 4 for break");

            char alfabet= 'A';
            switch (alfabet)
            {

                case 'A':
                    Console.WriteLine("it is A");
                    break;
                default:
                    Console.WriteLine("it is B");
                    break;

            }


            // بوئەوەی زیاتر فێربی .
            //نموونەی زیاتر تاقیبکەوە


        }
    }
}
