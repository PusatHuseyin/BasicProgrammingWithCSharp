namespace C06_MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mathematical Operations 
            int num1 = 30, num2 = 20;     
            double num3 = 12.5;            
            string name = "Ali";           

            Console.WriteLine(name + num1 + num2);  // String ile sayilari birlestirme (concatenation)
                                                    // Cikti: Ali3020 olacaktir (sayilar toplanmaz)

            Console.WriteLine(num1 + num2);        // Toplama islemi: 30 + 20 = 50
            Console.WriteLine(num1 - num2);        // Cikarma islemi: 30 - 20 = 10
            Console.WriteLine(num1 * num2);        // Carpma islemi: 30 * 20 = 600

            Console.WriteLine((double)num1 / num2); // num1 double'a cast ediliyor cunku
                                                    // iki int bolundugunde sonuc int olur ve ondalik kisim kaybolur
                                                    // Cast ile tam sonuc alinir: 30.0 / 20 = 1.5

            Console.WriteLine((double)num1 / (double)num2); // Her iki deger de double'a cast ediliyor
                                                            // Sonuc yine 1.5 olur

            Console.WriteLine(num1 % num2);        // Mod islemi (kalan bulma): 30 % 20 = 10

            Console.WriteLine(num1 / num3);        // Int ve double bolunmesi: 30 / 12.5 = 2.4
                                                   // (Otomatik tur donusumu yapilir, int double'a cevirilir)

            Console.Read();                     
        }
    }
}