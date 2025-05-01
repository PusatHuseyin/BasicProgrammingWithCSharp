namespace C34_ForExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0'den kullnicidan alinan sayiya kadar istedigi araliklarla yazdirma
            Console.Write("Sayi girin: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Artis miktarini girin: ");
            int artis = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i += artis)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
