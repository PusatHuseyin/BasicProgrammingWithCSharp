namespace C09_AreaAndPerimeterExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Karenin ve Dikdörtgenin Alanları ve Çevrelerini Hesaplama
            double squareEdge, rectangleShortSide, rectangleLongSide;
            Console.Write("Enter square edge: ");
            squareEdge = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of the square: " + (squareEdge * squareEdge));
            Console.WriteLine("Perimeter of the square: " + (4 * squareEdge));

            Console.Write("\nEnter the short side of the rectangle: ");
            rectangleShortSide = double.Parse(Console.ReadLine());

            Console.Write("Enter the long side of the rectangle: ");
            rectangleLongSide = double.Parse(Console.ReadLine());

            Console.WriteLine("Area of the rectangle: " + (rectangleShortSide * rectangleLongSide));
            Console.WriteLine("Perimeter of the rectangle: " + (2 * (rectangleShortSide + rectangleLongSide)));


            Console.Read();
        }
    }
}
