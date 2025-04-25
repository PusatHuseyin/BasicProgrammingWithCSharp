namespace C04_InputOutputExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Getting the name, age and height of the user

            Console.Write("Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your heiht: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Your name: " + name + " - Your Age: " + age + " - Your Height: " + height);

            Console.Read();
        }
    }
}
