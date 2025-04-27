namespace C17_IfElseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // grade point average
           double grade1, grade2, final, average;
            Console.Write("Grade1: ");
            grade1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Grade2: ");
            grade2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final: ");
            final = Convert.ToDouble(Console.ReadLine());
            average = grade1 * 0.2 + grade2 * 0.2 + final * 0.6;

            if (average >= 90)
            {
                Console.WriteLine("Average: {0} - AA", average);
            }
            else if (90 > average && average >= 80)
            {
                Console.WriteLine("Average: {0} - BA", average);
            }
            else if (80 > average && average >= 70)
            {
                Console.WriteLine("Average: {0} - BB", average);
            }
            else if (70 > average && average >= 60)
            {
                Console.WriteLine("Average: {0} - CB", average);
            }
            else if (60 > average && average >= 50)
            {
                Console.WriteLine("Average: {0} - CC", average);
            }
            else
            {
                Console.WriteLine("Average: {0} - FF", average);
            }
            Console.Read();
        }
    }
}
