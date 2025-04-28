using System;

namespace C19_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = true; // Program tekrar calissin mi?
            char process; // Islem turu (+, -, *, /, %)
            double num1, num2, result = 0; // Sayilar ve sonuc

            do
            {
                // Kullaniciya sayilar sorulur
                Console.WriteLine("\nEnter num1 and num2: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                num2 = Convert.ToDouble(Console.ReadLine());

                // Islem turu alinir
                Console.WriteLine("Enter Process (+, -, *, /, %), Exit --> x, X: ");
                process = Console.ReadKey().KeyChar;
                Console.WriteLine("Process: " + process);

                // Islemler
                if (process == '+')
                {
                    result = num1 + num2; // Toplama
                }
                else if (process == '-')
                {
                    result = num1 - num2; // Cikarma
                }
                else if (process == '*')
                {
                    result = num1 * num2; // Carpma
                }
                else if (process == '/')
                {
                    if (num2 == 0)
                    {
                        // Sifira bolme hatasi
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        continue; // Donguye yeniden basla
                    }
                    result = num1 / num2; // Bolme
                }
                else if (process == '%')
                {
                    result = num1 % num2; // Mod alma
                }
                else if (process == 'x' || process == 'X')
                {
                    again = false; // Programi durdur
                    continue;
                }
                else
                {
                    // Gecersiz islem girildi
                    Console.WriteLine("Incorrect Process!");
                    continue;
                }

                // Sonucu yazdir
                Console.WriteLine("{0} {1} {2} = {3}", num1, process, num2, result);
            }
            while (again); // Kullanici cikana kadar devam et
        }
    }
}
