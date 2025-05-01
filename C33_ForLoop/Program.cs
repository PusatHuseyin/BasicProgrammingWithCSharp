namespace C33_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // with while
            int num = 1;
            while (num <= 10)
            {
                Console.WriteLine(num);
                num++;
            }

            // with for
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            int j = 1;
            for (j = 0; j <= 10; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("End j =" + j);
            Console.Read();
        }
    }
}
