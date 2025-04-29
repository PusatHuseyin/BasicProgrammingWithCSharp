using System;

namespace C27_SumBetweenTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 sayi arasindaki sayilari toplama (1. yontem)
            Console.Write("Birinci sayiyi girin: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ikinci sayiyi girin: ");
            int num2 = int.Parse(Console.ReadLine());

            int num3 = num1; // 2. yontem icin kopya
            int num4 = num2;

            int total = 0;

            if (num1 > num2)
            {
                // num1 buyukse, azalarak topla
                while (num1 >= num2)
                {
                    total += num1;
                    num1--;
                }
                Console.WriteLine(num1 + "' den " + num2 + "' ye kadar toplam: " + total);
            }
            else
            {
                // num2 buyukse, azalarak topla
                while (num2 >= num1)
                {
                    total += num2;
                    num2--;
                }
                Console.WriteLine(num2 + "' den " + num1 + "' ye kadar toplam: " + total);
            }

            // 2. yontem: tek bir donguyle iki sekilde de topla
            int loopCount = num3 - num4;
            int total2 = 0;

            // negatif fark varsa pozitif yap
            if (loopCount < 0)
            {
                loopCount = -loopCount;
            }

            loopCount++; // sinirlar dahil edilecek

            while (loopCount > 0)
            {
                if (num3 > num4)
                {
                    total2 += num3;
                    num3--;
                }
                else
                {
                    total2 += num4;
                    num4--;
                }
                loopCount--;
            }

            Console.WriteLine("2. yontemle toplam: " + total2);

            Console.Read(); 
        }
    }
}
