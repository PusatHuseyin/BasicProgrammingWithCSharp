namespace C35_ForStarExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Baklava Dilimi Satir Sayisi: ");
            int row = Convert.ToInt32(Console.ReadLine());

            // Eger girilen sayi ciftse, 1 eklenerek tek yapilir (simetrik olmasi icin)
            row = row % 2 == 0 ? row + 1 : row;

            if (row % 2 != 0)
            {
                Console.WriteLine("Girdiginiz sayi cift oldugundan +1 eklendi.");
                Console.WriteLine("Baklava Dilimi Satir Sayisi: " + row + " oldu");
                Console.WriteLine();
            }

            // Ilk satirda bosluk sayisi, satir sayisinin yarisidir
            int space = row / 2;

            // Ilk satirdaki yildiz sayisi 1
            int star = 1;

            // Toplam satir kadar dongu doner
            for (int i = 0; i < row; i++)
            {
                // Satir basindaki bosluklar yazdirilir
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }

                // Yildizlar yazdirilir
                for (int k = 0; k < star; k++)
                {
                    Console.Write("*");
                }

                // Eger ust yarisindaysa: bosluk azalir, yildiz artar
                if (i < row / 2)
                {
                    space--;
                    star += 2;
                }
                // Alt yarisindaysa: bosluk artar, yildiz azalir
                else
                {
                    space++;
                    star -= 2;
                }

                // Satir sonu alta gec
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
