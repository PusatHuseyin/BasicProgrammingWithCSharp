namespace C28_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Factorial
            while (true)
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                int originalNumber = number;
                int factorial = 1;
                if (number >= 0)
                {
                    while (number > 0)
                    {
                        factorial *= number;
                        number--;
                    }
                    Console.WriteLine($"{originalNumber}! = {factorial}");
                }
                else
                {
                    Console.WriteLine("Please do not enter numbers less than 0");
                }
            }
          

            
        }
    }
}
