using System;

namespace C22_DepartmentSalaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Show department options to the user
            Console.WriteLine("Select a department to view salary range:");
            Console.WriteLine("1. Sales");
            Console.WriteLine("2. Marketing");
            Console.WriteLine("3. Engineering");
            Console.WriteLine("4. Human Resources");
            Console.WriteLine("5. Finance");

            // Ask the user to enter a department number
            Console.Write("Enter the department number (1-5): ");
            int department = Convert.ToInt32(Console.ReadLine());

            // Switch-case to display the salary range for the selected department
            switch (department)
            {
                case 1:
                    Console.WriteLine("Sales Department: $40,000 - $60,000");
                    break;
                case 2:
                    Console.WriteLine("Marketing Department: $50,000 - $75,000");
                    break;
                case 3:
                    Console.WriteLine("Engineering Department: $70,000 - $120,000");
                    break;
                case 4:
                    Console.WriteLine("Human Resources Department: $45,000 - $70,000");
                    break;
                case 5:
                    Console.WriteLine("Finance Department: $60,000 - $100,000");
                    break;
                default:
                    Console.WriteLine("Invalid department number. Please enter a number between 1 and 5.");
                    break;
            }

            Console.Read();
        }
    }
}
