using System;

namespace C24_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // 1. Ornek: 1'den 5'e kadar sayilari yazdir
            int sayac = 1;
            while (sayac <= 5)
            {
                Console.WriteLine("Sayi: " + sayac);
                sayac++; // sayaci 1 artir
            }

            // 2. Ornek: kullanici sifre dogru girene kadar sor
            string sifre = "";
            while (sifre != "1234")
            {
                Console.Write("Sifre girin: ");
                sifre = Console.ReadLine(); // kullanicidan giris al
            }
            Console.WriteLine("Dogru sifre!"); // dogru giris yapilinca mesaj

            Console.Read();
        }
    }
}
