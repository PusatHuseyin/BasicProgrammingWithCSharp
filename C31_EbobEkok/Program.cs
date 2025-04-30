namespace C31_EbobEkok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ebob-Ekok
            Console.Write("Enter number1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int originalNum1 = num1, originalNum2 = num2;
            num1 = num1 < 0 ? -num1 : num1;
            num2 = num2 < 0 ? -num2 : num2;
            int ebob = 1, ekok = 1;
            // Ebob
            while (num1 != 0 && num2 != 0)
            {
                if (num1 > num2)
                {
                    num1 = num1 % num2;
                }
                else
                {
                    num2 = num2 % num1;
                }
            }
            ebob = num1 + num2;
            Console.WriteLine($"EBOB({originalNum1}, {originalNum2}) = {ebob}");
            // Ebob 2. solution
            num1 = originalNum1;
            num2 = originalNum2;
            num1 = num1 < 0 ? -num1 : num1;
            num2 = num2 < 0 ? -num2 : num2;
            int orjNum1 = num1, orjNum2 = num2;
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 -= num2;
                }
                else
                {
                    num2 -= num1;
                }
            }
            Console.WriteLine($"EBOB({originalNum1}, {originalNum2}) = {num1}");
            // Ekok
            ekok = (orjNum1 * orjNum2) / ebob;
            Console.WriteLine($"EKOK({originalNum1}, {originalNum2}) = {ekok}");

            Console.Read();
        }
    }
}
