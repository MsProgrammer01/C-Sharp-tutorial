using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Switch statement
          

            سویچ کەیس وەک یف کوندیشنە .وە لێرەدا مامەلە لەگەل پارامیتەر دەکرێت ستێپ ستێپ 
                                                    تو ئازادیت یف بەکاربێنی یان سویچ کەیس 
                     بەلام عادەتەن بو ئەو پرسیارانەی کە دورو درێژن کودەکەیان  سویچ بەکاردێت
                                  لە سویچ کەیسدا  تو کەیست هەیە لەگل ستێتمێنت وە لەگەل برێک
                                                     ئەو شتەی کە دەتەوێت مامەلەی لەگەلبکەیت
                              لەناو کەوانەی سویچەکەدا دەنوسیت کە ناودەبرێت بە تێست ئێکسپرێشن 
                                    وە ئەو ئەگەرانەی بوی دادەنێیت لەناو  کەیسەکاندا دەنوسیت 
            دواتر بو هەر کەەیسێک برێکێک دادەنێیت تاوەکو ئەگەر ولام راست بێت نەچێتە هەنگاوی داهاتوو 



            Switch(TestExpression)
            {
            case Expression 0:
                  statement
            break;
             case Expression 1:
                  statement
            break;
             case Expression 2:
                  statement
            break;
             case Expression 3:
                  statement
            break;
            ...
            ...
            ...
            defualt:
            statement;
            break;

            */



            /*
            ئەگەر لێرە دیقەت بەین ژمارە دەمان هێناوەتە نێو سویچ لەرێگەی ڤەریبلی ئێکسەوە 
                              دەلێین هەریەکە لەو کەیسانە ژمارە دەبوو ستێتمێنتەکەی رەن بکە
           وە ئەگەر هیچیان ژمارە دە نەبوون ستێتمێنتی دیفولت رەن بکە کە وەکو ئێلسە کارکردنی
             
             */


            int x = 10;

            switch (x)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 10:
                    Console.WriteLine("ten");
                    break;
                default:
                    Console.WriteLine("Nothing");
                    break;

            }
            //run=ten


            /*
             لێرەدا من تەنها شێوازی کارکردنەکەیم رونکردوتەوە بە نموونەیەکی سادە
            گەر دەتەوێت زیاتر فێربی نموونەی زیاتری لەسەر تاقیبکەوە تا توشی هەلە ببیت و
                                                          بەتەواوی لەهەلەکانتەوە فێربی 
             */


        }
    }
}
