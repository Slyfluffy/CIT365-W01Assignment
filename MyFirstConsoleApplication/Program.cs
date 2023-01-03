using System;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // step 2
            string name = "Journey Curtis";
            string location = "Utah, United States";

            // step 3
            Console.WriteLine($"My name is {name},");
            Console.WriteLine($"I am from {location}.");

            // steps 4 and 5
            Console.WriteLine($"Current day: {DateTime.Now.ToShortDateString()}");
            Console.WriteLine($"Days till Christmas: {(new DateTime(2023, 12, 25) - DateTime.Now).Days}");

            // start step 6
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Enter the width: "); // step 7
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter the length: "); // step 7
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            // end step 6
            Console.ReadKey(); // step 7
        }
    }
}
