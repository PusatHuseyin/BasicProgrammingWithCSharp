using System;

namespace C23_ClassSectionStudentCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables to store student counts for each section
            int studentCountA, studentCountB, studentCountC, studentCountD, studentCountE;

            // Get the student count for each section from the user
            Console.Write("Enter the number of students for Section A: ");
            studentCountA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of students for Section B: ");
            studentCountB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of students for Section C: ");
            studentCountC = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of students for Section D: ");
            studentCountD = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of students for Section E: ");
            studentCountE = Convert.ToInt32(Console.ReadLine());

            // Ask the user for the section code they want to know the student count for
            Console.WriteLine("\nSelect the section code to view student count:");
            Console.WriteLine("A. Section A");
            Console.WriteLine("B. Section B");
            Console.WriteLine("C. Section C");
            Console.WriteLine("D. Section D");
            Console.WriteLine("E. Section E");

            // Ask the user to enter a section code
            Console.Write("Enter the section code (A-E): ");
            string sectionCode = Console.ReadLine().ToUpper();  // Read input and convert to uppercase

            // Switch-case to display the student count for the selected section
            switch (sectionCode)
            {
                case "A":
                    Console.WriteLine($"Section A: {studentCountA} students");
                    break;
                case "B":
                    Console.WriteLine($"Section B: {studentCountB} students");
                    break;
                case "C":
                    Console.WriteLine($"Section C: {studentCountC} students");
                    break;
                case "D":
                    Console.WriteLine($"Section D: {studentCountD} students");
                    break;
                case "E":
                    Console.WriteLine($"Section E: {studentCountE} students");
                    break;
                default:
                    Console.WriteLine("Invalid section code. Please enter a valid section letter (A-E).");
                    break;
            }

            Console.Read();
        }
    }
}
