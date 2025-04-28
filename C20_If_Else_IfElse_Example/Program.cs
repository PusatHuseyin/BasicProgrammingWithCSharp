using System;

namespace C20_If_Else_IfElse_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Age Stages (Casual English)
            /*
            0–2     Baby
            2–6     Little Kid
            6–12    Kid
            12–18   Teenager
            18–25   Young Adult
            25–40   Adult
            40–65   Middle-aged Adult
            65+     Older Adult
            */

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                if (age < 2)
                {
                    Console.WriteLine("0-2: Baby");
                }
                else if (age < 6)
                {
                    Console.WriteLine("2-6: Little Kid");
                }
                else if (age < 12)
                {
                    Console.WriteLine("6-12: Kid");
                }
                else
                {
                    Console.WriteLine("12-18: Teenager");
                }
            }
            else
            {
                if (age < 25)
                {
                    Console.WriteLine("18-25: Young Adult");
                }
                else if (age < 40)
                {
                    Console.WriteLine("25-40: Adult");
                }
                else if (age < 65)
                {
                    Console.WriteLine("40-65: Middle-aged Adult");
                }
                else
                {
                    Console.WriteLine("65+: Older Adult");
                }
            }

            Console.Read();
        }
    }
}
