namespace C14_SwapUsingTemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Swap Numbers Using Temp Variable
            int num1, num2;

            Console.Write("Number1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number1: {0}, Number2: {1}", num1, num2);

            // Sayi degerlerini yer degistirmek icin 'temp' kullaniyoruz
            int temp;
            
            temp = num1;    // temp degiskeni num1'in degerini tutacak sekilde atanir
            num1 = num2;     // num1'e num2'nin degeri atanir
            num2 = temp;    // num2'ye temp degiskenindeki num1'in degeri atanir

            Console.WriteLine("Number1: {0}, Number2: {1}", num1, num2);

            Console.Read();
        }
    }
}
