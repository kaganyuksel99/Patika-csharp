using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 5;  1 byte  
            //sbyte b = 5; 1 byte 
            //short c = 5;  2 byte 
            //ushort us = 5; 2 byte  

            /* REEL SAYILAR
            float f = 5;  // 4 byte  
            double d = 5; // 8 byte 
            decimal de = 5;  // 16 byte  

            char v = '2';  // 2 byte 
            String n = "Kağan"; // sınırsız */

            //bool b1 = true; 
            //bool b2 = false;  

            DateTime dt = DateTime.Now; 
            Console.WriteLine(dt);   
            object o1 = "x"; 


            // String ifadeler  
            String str1 = string.Empty;  


            //DEĞİŞKEN DÖNÜŞÜMLERİ  
            String str20 = "20"; 
            int int20 = 20; 

            String yeniDeger = str20 + int20.ToString(); 
            Console.WriteLine(yeniDeger);  

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20); // çıktısı 40 

            // DATETİME 
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime); 

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2); 

            
         } 
    }
}
