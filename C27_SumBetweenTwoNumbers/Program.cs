namespace C27_SumBetweenTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 sayi arasindaki sayilari toplama
            Console.Write("Birinci sayiyi girin: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ikinci sayiyi girin: ");
            int num2 = int.Parse(Console.ReadLine());
            int total = 0;
            if (num1 > num2)
            {
                while (num1 >= num2)
                {
                    total += num1; 
                    num1--; 
                }
                Console.WriteLine(num1 +"' den "+ num2+ "' ye kadar toplam: " + total);
            }
            else
            {
                while (num2 >= num1)
                {
                    total += num2;
                    num2--;
                }
                Console.WriteLine(num2 + "' den " + num1 + "' ye kadar toplam: " + total);
            }

            Console.Read();
        }
    }
}
