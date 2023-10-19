using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Array
                                    ئەرەی بریتیە لە کومەلێک ئێلێمێنت ،کە بەیێک ڤەریبل پیشان دەدرێن ،
                              وە دەتوانین ئەو یێک ڤەریبلە بەکاربێنین بو پیشاندانی تاک بەتاکی داتاکان 
                                    .وە سودیشی زورە یێکێک لە سودەکانی کەمکردنەوەی سایزی پروگرامەکەتە 
                                                        هەموو ئێلێمێنتەکانی نێو ئەرەی دەبێ یێک جور بن
               نموونە گەر تێکست داخل بکەیت دەبێ هەموو سترینگ بن ، گەر ژمارەبیت دەبێ هەموو ینتیجەر بن  

                                                            قەبارەی ئەرەی بریتیە لە ژمارەی یندێکسەکان  
                                                   .هەر ئێلێمێنتێک دوو پارتە خودی ژمارەکەو یندێکسەکەی  
                                               یندێکسەکان لە سفرەوە دەسپێدەکەن . لە دەستە چەپ بو راست 


           int [] num= {1,3,5,6};


           int --> variblr
           num -->array name
           []  --- bracket
           1,3,5,6  -- element

           length of num =3
             1= index 0
             3= index 1
             5= index 2
             6= index 3

            */



            int[] arr = { 1, 3, 6 };
            Console.WriteLine(arr[1]);    // output=3      لێرەدا دەلێم یندێکسی دووم بو بێنە کە ژمارە شەشە 
            Console.WriteLine(arr.Length);  //output=3     لێرەدا سێ ئێلێمێنت هەیە بویە ژمارە سێ دەنوسێت لە قەبارەدا کە بانگی دەکەیت

            //ئەگەر بتەوێت هەموویان ببینی لە ئاوتپوت  فورلوپ دەبێ بەکاربێت

            int[] arr1 = { 17, 300, 600 };
            for (int i = 0; i < arr.Length; i++)            // arr.length =3
            {
                Console.WriteLine(arr1[i]);               // arr[0] , arr[1] , arr[2]
            }

        }
    }
}

