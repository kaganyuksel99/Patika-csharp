using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            // Expression = kontrol edilmek istenen koşul 
            switch (month)
            {
                case 1: 
                    Console.WriteLine("Ocak ayındasınz"); 
                     break;
                case 2: 
                    Console.WriteLine("Şubat ayındasınz"); 
                     break; 
                case 10: 
                    Console.WriteLine("Ekim ayındasınz"); 
                     break; 
                case 3: 
                    Console.WriteLine("Mart ayındasınz"); 
                     break;
                default: // hiçbir case 'e  uyulmadığı taktirde yapılmasını isteneni yazıyoruz. 
                    Console.WriteLine("Yanlış veri girişi");
                break;
                }
            switch (month)
            {
                case 12: 
                case 1: 
                case 2: 
                    Console.WriteLine("Kış ayındasınız"); 
                    break; 
                case 3: 
                case 4: 
                case 5: 
                    Console.WriteLine("İlkbahar ayındasınız"); 
                    break; 
                case 6: 
                case 7: 
                case 8: 
                    Console.WriteLine("Yaz ayındasınız"); 
                    break; 
                case 9: 
                case 10: 
                case 11: 
                    Console.WriteLine("Sonbahar ayındasınız"); 
                    break;
                default:
                break;
            }
        }
    }
}
