namespace C04_InputOutputExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanici bilgilerini alma islemi baslatilir (name, age, height)

            // Kullaniciya isim sorulur ve string olarak alinir
            Console.Write("Your Name: ");
            string name = Console.ReadLine();

            // Kullaniciya yas sorulur, girilen deger int'e cevrilir
            Console.Write("Your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Kullaniciya boy bilgisi sorulur, float olarak okunur
            Console.Write("Your height: ");  
            float height = float.Parse(Console.ReadLine());

            // Alinan bilgileri formatli sekilde ekrana yazdirir
            Console.WriteLine("Your name: " + name + " - Your Age: " + age + " - Your Height: " + height);

            Console.Read();
        }
    }
}
