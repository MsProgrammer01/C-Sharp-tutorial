﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*     
                                                      If Statement
                          بلوک کودێکە بەکاردێت بو دانانی مەرج بۆ داتاکان 
                              نموونە دەتەوێت بچیت بۆ بازار وتومبێل بکریت   
         دەلێیت ئەگەر وتومبێلەکە سپی بێت دەمەوێت ئەگەر سپی نەبوو نامەوێت 
             If ئەو ئەگەرەی نوسراوە لەسەرەتادا لەکود چنیندا دەتوانرێت بە  
                      بنوسرێت بە دانانی کومەلێک مەرج یان بارووخ لەنێویدا






            شێوازی سادەی دەربرینی 


            if (  یان مەرج condition  )
            {
                  ئەگەر مەرجەکە راست بوو ئەو شتەی لێرە دەنوسرێ جا تێکست بێت 
                  یان حساباتێکی بیرکاری بێت یان هەر شتێک کە دەتەوێت جێبەجێ بێت
                  لەکاتی راست بونی مەرجەکە وە بەو ناوەندە دەوترێ بلوک کود 
            }
            */



            // X = y لێرەدا کوتومانە ئەگەر ئەو ژمارەیەی نێو ئێکس یێکسانبێت بەو ژمارەیەی وای با بنوسرێت
      
            int x = 10;
            int y = 10;

            if (x == y)
            {
                Console.WriteLine("x=y");
            }



            //ئەگەر ئەی گەورەتربێت لە بی  بنوسە ئەی گەورەترە لە بی بەس لێرە ئەی دوازدەیە وە بی سیانزەیە
                                  //بویە مەرجەکە جێبەجێ نابێت وە دەچێتە دەرەوە وە بلوک کودەکە رەن نابێت 
            int a = 12;
            int b = 13;


                //ئەگەر ئەی بچوکتربێت لە بی  بنوسە ئەی بچوکترە لە بی  لێرەدا ئەی دوازدەیە وە بی سیانزەیە
                                                      //بویە مەرجەکە جێبەجێ دەبێت چونکە ئەی بچوکترە لە بی
            if (a< b)
            {
                Console.WriteLine("a < b ");
            }


                                                 //ئەگەر ئەی گەورەتربێت لە بی ئەوا با بلوک کودەکە رەن بێت
                    //وە لێرەدا ئەی 12 یە وە بی 13 یە وە ئەی گەورەتر نیە لە بی بویە رەن نابێت بلوک کودەکە

            if (a>b)
            {
                Console.WriteLine("a > b");
            }

             
                                                    //ئەگەر ئەی گەورەتربێت یان یەکسان بێت بە بی  ئەوا با رەن بێت بلوک کودەکە
                                         //ئەگەر سەیری بکەین ئەی گەورەتر نیە لە بی وە یەکسانیش نیە بە بی کەواتە جێبەجێ نابێت
                     //بەلام گەر ئەی یێکسانبا بە ژمارە 13 لەجیاتی ژمارە 12 ئەوکات مەرجەکە راست دەبوو وە رەن دەبوو بلوک کودەکە
                   
            if (a >= b)
            {
                Console.WriteLine(" a >= b ");
            } 



                                            //ئەگەر ئەی یێکسان نەبوو بە بی ئەوا بنوسە ئەی یێکسان نیە بە بی
            if (a != b)
            {
                Console.WriteLine("a != b");
            }


                                                          //ئەگەر ئەی یێکسان نەبوو بە بی ئەوا ئەی کو بی بکە 
            if (a != b)
            {
                Console.WriteLine(a + b);
            }


            //ئەمەش شێوازێکی تریەتی دەتوانی بینوسیت نموونە گەر دە گەورەتر بوو لە نوو ژمارە دە جارانی نوو بکە
                                      //وە لێرەدا توو دەتوانی ژمارەکانیش بگوری یان شێوازی دەربرینی بیرکاریەکە
            if (10 > 9)
            {
                Console.WriteLine(9*10);
            }
        }
    }
}

