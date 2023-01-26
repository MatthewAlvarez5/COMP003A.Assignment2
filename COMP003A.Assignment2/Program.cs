/*
    * Author: Matthew Alvarez
    * Course: COMP-003A
    * Purpose: Assignment for Week 2 Simple String and integer conversions
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
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("String Section");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.Write("What is Your First Name?: ");
            string firstName = Console.ReadLine();
            Console.Write("What is Your Middle Name?: ");
            string middleName = Console.ReadLine();
            Console.Write("What is Your Last Name?: ");
            string lastName = Console.ReadLine();
            Console.Write("How old will you be in 2023?: ");
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.\n");

            /* Math Section */
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Math Section");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.Write("Enter a digit: ");
            string integer1Text = Console.ReadLine();
            int integer1 = Convert.ToInt32(integer1Text);
            Console.Write("Enter a second digit: ");
            string integer2Text = Console.ReadLine();
            int integer2 = Convert.ToInt32(integer2Text);
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}\n");

            /* Circle Area and Circumference */
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Circle Area & Circumference Section");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.Write("Give a Radius of a Circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"With a radius of {radius}, the area is: {area}, the circumference is: {circumference}");
            Console.WriteLine("This is the end of our journey today, salutations!");
        }
    }
}