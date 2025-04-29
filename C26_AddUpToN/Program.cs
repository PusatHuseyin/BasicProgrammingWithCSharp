using System;

namespace C26_AddUpToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayi girin: ");
            int num = int.Parse(Console.ReadLine());

            int count = 1, total = 0, total2 = 0;

            // 1. yontem: count degiskeni ile 1'den num'a kadar topla
            while (count <= num)
            {
                total += count; // toplama ekle
                count++;        // bir sonraki sayiya gec
            }

            // toplami ekrana yazdir
            Console.WriteLine("1' den " + num + "'ye kadar sayilarin toplami: " + total);

            int num2 = num; // orijinal degeri sakla (cunku asagida num azaltilacak)

            // 2. yontem: num'dan 1'e kadar geri sayarak topla
            while (num > 0)
            {
                total2 += num; // toplama ekle
                num--;         // bir azalt
            }

            // 2. yontemle elde edilen toplami yazdir
            Console.WriteLine("1' den " + num2 + "'ye kadar sayilarin toplami2: " + total2);
        }
    }
}
