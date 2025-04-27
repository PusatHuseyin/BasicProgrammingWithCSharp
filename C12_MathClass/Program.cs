namespace C12_MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Math Class

            Console.WriteLine(Math.Pow(2, 3));  // 2³
            Console.WriteLine(Math.Sqrt(25));   // √25
            Console.WriteLine(Math.Max(-2, 25));  // -2 ve 25'in en buyugunu verir
            Console.WriteLine(Math.Floor(4.98));    // Asagi yuvarlama
            Console.WriteLine(Math.Ceiling(4.45));  // Yukari yuvarlama

            // Math.Abs: Bir sayinin mutlak degeri
            Console.WriteLine(Math.Abs(-100)); // 100

            // Math.Round: Bir sayiyi en yakina yuvarlar (ondalik kisimdan)
            Console.WriteLine(Math.Round(3.14159, 2)); // 3.14

            // Math.Sin, Math.Cos, Math.Tan: Trigonometrik fonksiyonlar
            Console.WriteLine(Math.Sin(Math.PI / 2));  // Sin(90°) = 1
            Console.WriteLine(Math.Cos(Math.PI));      // Cos(180°) = -1
            Console.WriteLine(Math.Tan(Math.PI / 4));  // Tan(45°) = 1

            // Math.Log: Bir sayinin dogal logaritmasi
            Console.WriteLine(Math.Log(10));  // log(10) ≈ 2.3026

            // Math.Exp: e ussu
            Console.WriteLine(Math.Exp(1));   // e^1 ≈ 2.71828

            // Math.PI: Pi sayisi
            Console.WriteLine(Math.PI); // 3.14159265358979
        }
    }
}
