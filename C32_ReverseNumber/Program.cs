namespace C32_ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int reverseNum = 0;
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());  
                int orjNum = num;
                do
                {
                    reverseNum = reverseNum * 10;
                    reverseNum = reverseNum + (num % 10);
                    num /= 10;
                }
                while (num != 0);
                Console.WriteLine($"Reverse Number{orjNum}: {reverseNum}");
            }
        }
    }
}
