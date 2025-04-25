namespace C05_OtherTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 'var' ve 'const' degisken tipleri
            var num = 5;           // Derleyici tipini int olarak belirler
            var name = "Ali";      // Derleyici tipini string olarak belirler
            var decimalNum = 3.55; // Derleyici tipini double olarak belirler
            var key = false;       // Derleyici tipini bool olarak belirler
            var character = 'C';   // Derleyici tipini char olarak belirler
            Console.WriteLine(num + name + decimalNum + key + character);

            const double PI = 3.14159; // Sabit degisken tanimlamasi, degeri degistirilemez
            Console.WriteLine(PI);

            // PI = 3114; // X HATA: const ile tanimlanan degiskenler degistirilemez
                       // const degiskenler tanimlandiklari anda deger alirlar ve sonradan degerleri degistirilemez
        }
    }
}