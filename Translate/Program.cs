using System;
using System.Net;
using System.Text;
using System.IO;

namespace TranslationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\trety\Downloads\1.txt");
            string[,] num = new string[lines.Length, lines[0].Split(' ').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                    num[i, j] = temp[j];
            }
            // проверяем выводом на консоль
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                { 
                    Console.WriteLine(num[i, j]); 
                }
                    
            }
            Console.WriteLine("\n\n\n");

            
            //for (int q = 0; q < num.GetLength(0); q++)
            //{
            //    for(int w = 0; w < num.GetLength(1); w++)
            //    {

                    
            //        if (num[q, w] == ">")
            //        {
            //            Console.WriteLine(num[q, w]);
            //            while (num[q, w] == "<")
            //            {
            //                Console.WriteLine(num[q, w]);
            //            }
            //            //do
            //            //{
            //            //    Console.WriteLine(num[i, j]);
            //            //}
            //            //while (num[i, j]!="<");
            //        }
            //    }
            //}
                
             




            Console.ReadKey();
        }   
    }
}
