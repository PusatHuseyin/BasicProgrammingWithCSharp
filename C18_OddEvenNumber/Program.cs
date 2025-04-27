namespace C18_OddEvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Odd or Even Number
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 ==0)
            {
                Console.WriteLine("{0} is Even.", num);
            }
            else
            {
                Console.WriteLine("{0} is Odd.", num);
            }
            Console.Read();
        }
    }
}
