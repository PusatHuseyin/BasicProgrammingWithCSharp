namespace C16_ControlStructuresIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            '<'  --> kucuktur       --> 5<6  true    6<5  false
            '>'  --> buyuktur       --> 5>6  false   6>5  true
            '<=' --> kucuk esittir  --> 5<=6 true    6<=5 false   5<=5  true
            '>=' --> buyuk esittir  --> 5>=6 false   6>=5 true    6>=6  true
            '==' --> esit esittir   --> 5==6 false   6==6 true
            '!=! --> esit degildir  --> 5!=6 true    6!=6 false

            '&&' --> ve             --> (1 && 1) true   (1 && 0) false   (0 && 1) false   (0 && 0) false  
            '||' --> veya           --> (1 || 1) true   (1 || 0) true    (0 || 1) true    (0 || 0) false
            */

            bool key = 5 < 6;   // key = false
            Console.WriteLine("Key: " + key);
            // Karsilastirma ornekleri:
            Console.WriteLine("5 < 6: " + (5 < 6));   // true
            Console.WriteLine("6 > 5: " + (6 > 5));   // true
            Console.WriteLine("5 <= 5: " + (5 <= 5)); // true
            Console.WriteLine("5 >= 6: " + (5 >= 6)); // false
            Console.WriteLine("5 == 5: " + (5 == 5)); // true
            Console.WriteLine("5 != 6: " + (5 != 6)); // true

            // Mantiksal operator ornekleri:
            Console.WriteLine("true && true: " + (true && true));   // true
            Console.WriteLine("true && false: " + (true && false)); // false
            Console.WriteLine("false || true: " + (false || true)); // true
            Console.WriteLine("false || false: " + (false || false)); // false

            // If-else 
            int age = 18;
            if (age >= 18)
            {
                Console.WriteLine("Yas resit. Ehliyet alabilir."); // 18 ve uzeri icin
            }
            else
            {
                Console.WriteLine("Ehliyet alamaz!"); // 18'den kucukler icin
            }

            Console.Read();
        }
    }
}
