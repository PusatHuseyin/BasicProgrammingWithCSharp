namespace C29_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do while
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int orijinalNum = num;
            int total = 0;
            do
            {
                total += num;
                num--;
            }
            while (num > 0);
            Console.WriteLine($"The total is: {total}");

            int total2 = 0;
            while (orijinalNum > 0)
            {
                total2 += orijinalNum;
                orijinalNum--;
            }
            Console.WriteLine($"The total is: {total2}");

            Console.Read();
        }
    }
}
