using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _03_UserInputAndOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            // I/O operations
            Console.Write("Hello World!");
            string universityName = "Necmettin Erbakan University";
            char character;

            Console.Write("Enter university name: ");
            universityName = Console.ReadLine();
        }
    }
}
