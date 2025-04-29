using System;

namespace C25_MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1, num2 = 1;

            // dis dongu: 1'den 10'a kadar olan sayilar icin
            while (num1 <= 10)
            {
                // ic dongu: her num1 degeri icin 1'den 10'a kadar carpim
                while (num2 <= 10)
                {
                    // carpim sonucunu ekrana yazdir
                    Console.WriteLine(num1 + "*" + num2 + "=" + num1 * num2);
                    num2++; // ic dongu sayacini artir
                }

                num1++;    // dis dongu sayacini artir
                num2 = 1;  // ic donguyu sifirla (yeniden 1 yap)
            }
        }
    }
}
