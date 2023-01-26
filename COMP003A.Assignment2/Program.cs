/*
    * Author: Matthew Alvarez
    * Course: COMP-003A
    * Purpose: Assignment for Week 2 
*/
namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            /* String section */
            Console.WriteLine("What is Your First Name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is Your Middle Name?");
            string middleName = Console.ReadLine();
            Console.WriteLine("What is Your Last Name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("How old will you be in 2023?");
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

            /* Math Section */
            Console.WriteLine("Enter a digit:");
            string integer1 = Console.ReadLine();

            Console.WriteLine("Enter a second digit:");
            string integer2 = Console.ReadLine();

        }
    }
}