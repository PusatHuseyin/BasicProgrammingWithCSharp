namespace C11_MathEquationSolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // f(x) = ax² + bx + c 
            // Delta (Δ) = b² - 4ac
            // f(2), f(4) 

            double a, b, c, x, result, delta;

            // Kullanicidan a, b, c ve x degerlerini sirayla aliyoruz
            Console.WriteLine("a, b, c ve x degerlerinin sirasiyla giriniz: ");
            a = Convert.ToDouble(Console.ReadLine()); 
            b = Convert.ToDouble(Console.ReadLine()); 
            c = Convert.ToDouble(Console.ReadLine()); 
            x = Convert.ToDouble(Console.ReadLine()); 

            // Verilen x degeri icin f(x) fonksiyonunun sonucu hesaplaniyor
            result = a * x * x + b * x + c; // ax² + bx + c 

            // Delta degeri: b² - 4ac
            delta = b * b - 4 * a * c;

            Console.WriteLine("f({0}): " + result + "\nDelta: " + delta, x);

            Console.Read();
        }
    }
}
