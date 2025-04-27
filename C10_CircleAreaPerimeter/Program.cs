namespace C10_CircleAreaPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dairenin cevresini ve alanini hesaplama - cevre --> 2πr, alan --> πr²

            const double pi = 3.14159; // Pi sabitini tanimliyoruz
            // double radius; // asagida 'var' olarak tanimlandi gerek kalmadi

            Console.Write("Radius of the circle; "); // Kullanicidan yaricap isteniyor
            var radius = Convert.ToDouble(Console.ReadLine()); // 'var' kullanilarak degiskenin veri tipi otomatik olarak belirlenir; burada girilen deger double oldugu icin radius degiskeni double olur

            double perimeter = 2 * pi * radius;
            double area = pi * radius * radius;

            Console.WriteLine("Dairenin Cevresi: " + perimeter + "\nDairenin Alani: " + area);

            Console.Read();
        }
    }
}
