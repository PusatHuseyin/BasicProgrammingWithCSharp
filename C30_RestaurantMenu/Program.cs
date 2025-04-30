namespace C30_RestaurantMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // restaurant menu
            double total = 0;
            do
            {
                Console.WriteLine("\n1. Kebab: 25.00 \n2. Salad: 12.50 \n3. Soup: 8.25 \n4. Tea: 4.75 \n5. Fish22.75 \n6. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        total += 25.00;
                        Console.WriteLine("Your Account: " + total);
                        break;
                    case 2:
                        total += 12.50;
                        Console.WriteLine("Your Account: " + total);
                        break;
                    case 3:
                        total += 8.25;
                        Console.WriteLine("Your Account: " + total);
                        break;
                    case 4:
                        total += 4.75;
                        Console.WriteLine("Your Account: " + total);
                        break;
                    case 5:
                        total += 22.75;
                        Console.WriteLine("Your Account: " + total);
                        break;
                    case 6:
                        Console.WriteLine("Your total is: " + total);
                        Console.WriteLine("Thank you for your order!");
                        return;
                    default:
                        Console.WriteLine("Please select a valid option.");
                        break;
                }
                Console.WriteLine("Your total is: " + total);
            }
            while (true);
        }
    }
}
