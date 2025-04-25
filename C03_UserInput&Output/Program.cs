using System;

namespace C03_UserInputAndOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konsolu temizler, onceki ciktilari siler
            Console.Clear();

            // Giris mesaji yazdirilir
            Console.WriteLine("Welcome to the Input/Output Demo!");
            Console.WriteLine("---------------------------------\n");

            // Universite adini alacak degisken tanimlanir
            string universityName;

            // Kullaniciya universite adini sorar
            Console.Write("Enter university name: ");
            universityName = Console.ReadLine();

            // Alinan universite adini ekrana yazdirir
            Console.WriteLine("University Name: " + universityName + "\n");

            // num1 icin ornek sayi alinir (Convert.ToInt32 kullanilir)
            Console.Write("Enter an integer for num1 (example use): ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // num2 icin giris alinir ve int'e cevrilir
            Console.Write("Enter an integer for num2 (Convert.ToInt32): ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // num3 icin int.Parse yontemi kullanilir
            Console.Write("Enter an integer for num3 (int.Parse): ");
            int num3 = int.Parse(Console.ReadLine());

            // num4 icin TryParse yontemi kullanilir, hatali giris varsa 0 atanir
            Console.Write("Enter an integer for num4 (int.TryParse): ");
            string tryInput = Console.ReadLine();
            int num4;
            if (!int.TryParse(tryInput, out num4))
            {
                // Giris hataliysa uyari verilir ve num4 = 0 olur
                Console.WriteLine("Invalid input for num4, defaulting to 0.");
                num4 = 0;
            }

            // num5 icin double veri tipi alinir (Convert.ToDouble ile)
            Console.Write("Enter a double for num5 (Convert.ToDouble): ");
            double num5 = Convert.ToDouble(Console.ReadLine());

            // num6 icin double.Parse yontemi kullanilir
            Console.Write("Enter a double for num6 (double.Parse): ");
            double num6 = double.Parse(Console.ReadLine());

            // num7 icin oncelikle double'a cevrilir, sonra float'a cast edilir
            Console.Write("Enter a float for num7 (Convert.ToDouble then cast to float): ");
            float num7 = (float)Convert.ToDouble(Console.ReadLine());

            // num8 icin direkt float.Parse yontemi kullanilir
            Console.Write("Enter a float for num8 (float.Parse): ");
            float num8 = float.Parse(Console.ReadLine());

            // Girilen tum sayilarin ve karelerinin ozeti yazdirilir
            Console.WriteLine("\n--- Summary ---");
            Console.WriteLine($"num1: {num1}, square: {num1 * num1}");
            Console.WriteLine($"num2: {num2}, square: {num2 * num2}");
            Console.WriteLine($"num3: {num3}, square: {num3 * num3}");
            Console.WriteLine($"num4: {num4}, square: {num4 * num4}");
            Console.WriteLine($"num5: {num5}, square: {num5 * num5}");
            Console.WriteLine($"num6: {num6}, square: {num6 * num6}");
            Console.WriteLine($"num7: {num7}, square: {num7 * num7}");
            Console.WriteLine($"num8: {num8}, square: {num8 * num8}");

            // Programdan cikmadan once tus beklenir
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
