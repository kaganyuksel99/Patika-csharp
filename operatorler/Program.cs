using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli atama 
            Console.WriteLine("***** ATAMA VE İŞLEMLİ ATAMA OPARETÖRLERİ *****");   
            
            int y = 3;  
            int x = 3;

            y+= 2; 
            Console.WriteLine(y);  
            y += 2; 
            Console.WriteLine(y);  
            y/=1;  
            Console.WriteLine(y);  
            x*=2; 
            Console.WriteLine(x);   

            // Mantıksal operatörler   
            Console.WriteLine("***** MANTIKSAL OPARETÖRLER *****");
            bool  isSuccess = true; 
            bool isComplated = false; 

            if(isSuccess && isComplated) {
                Console.WriteLine("Perfect!"); 
            }

            if (isSuccess || isComplated)
            {
                Console.WriteLine("Greate!");
            } 

            if (isSuccess && !isComplated)
            {
                Console.WriteLine("Fine!");
            } 

            // İlişkisel operatörler  
            Console.WriteLine("***** İLİŞKİSEL OPARETÖRLER *****");
            // < > <= >= == !=  
            int a = 3; 
            int b = 4; 
            bool sonuc = a<b; 
            Console.WriteLine(sonuc); 
            sonuc = a>b; 
            Console.WriteLine(sonuc); 
            sonuc = a >= b; 
            Console.WriteLine(sonuc); 
            sonuc = a <= b; 
            Console.WriteLine(sonuc);  
            sonuc = a == b; 
            Console.WriteLine(sonuc);  
            sonuc = a!=b; 
            Console.WriteLine(sonuc);  

            // ARİTMETİK OPERATÖRLER 
            Console.WriteLine("***** ARİTMETİK OPARETÖRLER *****"); 
            int sayi1 = 10; 
            int sayi2 = 5; 
            int sonuc1 = sayi1 / sayi2;  
            Console.WriteLine(sonuc1); 
            sonuc1 = sayi1 * sayi2; 
            Console.WriteLine(sonuc1); 
            sonuc1 = sayi1 +  sayi2;  
            Console.WriteLine(sonuc1);  
            sonuc1 = sayi1++; 
            Console.WriteLine(sonuc1);  

            // % : mod alma  
            Console.WriteLine("***** MOD ALMA OPARETÖRÜ *****");  
            int sonuc2 = 20 % 3; 
            Console.WriteLine(sonuc2);
        }
    }
}
