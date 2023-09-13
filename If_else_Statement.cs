using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*                                      if else Statement 
                                 یف ئێلس بەکاردێت بو درێژەدان بە ئەگەر 
            نموونە لە بازاری وتومبێل دەلێی ئوتومبێلێکی رەنگ رەشم دەوێت 
                                        . ئەگەر رەشکە نەبوو پێم بلێن نیە 
            
                          ئەو پێم بلێن نیەیەی کوتای کە دەنوسرێت بە ئێلس
                                 یانی بێ ولام جێم مەهێلن پێم بلێن کە نیه 


                                                 وە بەم شێوازە دەردەبرێت 

            if (condition )
            {
             Anything to do
            }
            else 
              Anything to do

            یان


            if (condition )
            {
             Anything to do
            }
            else if(condition )
            {
             Anything to do
            }
            else 
              Anything to do

            


                لە یف و ئێلسدا هەمیشە یێکێکیان جێبەجێ دەبێت یان یف یان ئێلس
                           ئێلس کە لە کوتایدا دەنوسرێت هیچ مەرجێکی پێنادرێت 

                    


            */




            /*
             ئەگەر لێرە سەیری بکەین دەلێین ئەگەر ئێکس گەورەتر بێت لە وای بنوسە ئێکس گەورەترە لە وای 
                          ئەگەرنا بنوسە ئێکس بچوکترە لە وای . وە لێرەدا تەنها یێکێکیان جێبەجێ دەبێت 
                    چونکە گوتمان لە یف ئێلس هەمیشە تەنها یێکێکیان جێبجێ دەبێت یان یفەکە یان ئێلسەکە 
              */
            int x = 10;
            int y = 20;
            if (x > y)
            {
                Console.WriteLine(" X > y ");
            }
            else
            {
                Console.WriteLine(" X < Y ");
            }







            /*
                                   لێرەدا ئەگەر سەیری بکەین ئەی مان هەیە لەگەل بی کە هەردوکیان ژمارە دونە 
                                               دەلێین ئەگەر ئەی گەورەتر بوو لە بی بنوسە ئەی گەورەترە لە بی 
                       بەس لێرە ئەی گەورەتر نیە لە بی چونکە هەردوک ژمارە دونە  بویە جێبەجێ نابێت ئەم مەرجە
                       وە دێتە سەر مەرجی دووەم ، دەلێین ئەگەر ئەی بچوکتر بێت لە بی بنوسە ئەی بچوکترە لە بی 
           وە دیسان لێرەش ئەم مەرجە جێبەجێ نابێت چونکە ئەی وە بی هەردکیان ژمارە دوونە وە بچوکتر نین لە یەکتر 
                              وە لە مەرجی سێیەمدا دەلێین ئەگەر ئەی یێکسان بێت بە بی بنوسە ئەی یێکسانە بە بی 
                                 وە چونکە مەرجەکە راستە بویە ئەمە رەن دەبێت  واتە ئێلس یفی سێیەم جێبەجێ دەبێت   

            */

            int a = 2;
            int b = 2;

            if (a > b)
            {
                Console.WriteLine(" a > b ");
            }
            else if (a< b)
            {
                Console.WriteLine(" a < b ");
            }
            else if (a == b)
            {
                Console.WriteLine(" a = b ");
            }
            else
                Console.WriteLine("nothing of them");




            //توو نموونەی زیاتر حەلکە وە داتا بێنەو ببە تاوەکوو زیاتر لە یف تێبگەیت 





        }
    }
}
