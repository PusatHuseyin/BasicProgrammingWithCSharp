using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C13_DigitsSumOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Baslangicta 4 basamakli bir sayi belirleniyor
            int num = 4253;

            // Kullanicidan 4 basamakli bir sayi girmesini istiyoruz
            Console.Write("Enter 4-digit number: ");
            num = Convert.ToInt32(Console.ReadLine());

            // Sayinin birler basamagini bulmak icin num % 10 islemi yapilir
            int ones = num % 10;

            // Sayinin onlar basamagini bulmak icin once 100'e bolup kalan ile islem yapilir
            int tens = (num % 100) / 10;

            // Sayinin yuzler basamagini bulmak icin once 1000'e bolup kalan ile islem yapilir
            int hundreds = (num % 1000) / 100;

            // Sayinin binler basamagini bulmak icin 10000'e bolup kalan ile islem yapilir
            int thousands = (num % 10000) / 1000;

            // Sayinin her bir basamagini ekrana yazdiriyoruz
            Console.WriteLine("Ones Digit: " + ones);
            Console.WriteLine("Tens Digit: " + tens);
            Console.WriteLine("Hundreds Digit: " + hundreds);
            Console.WriteLine("Thousands Digit: " + thousands);

            // Sayinin basamaklarinin toplamini hesaplama
            int result = ones + tens + hundreds + thousands;

            Console.WriteLine("Sum of digits of the number: " + result);

            Console.Read();
        }
    }
}
