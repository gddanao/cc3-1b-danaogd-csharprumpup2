﻿using System;

namespace CSharpRumpUp
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART 1
            Console.WriteLine("PART 1:");

            // Converts pounds to kilograms
            Console.Write("Enter weight in pounds(lbs): ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double kilograms = pounds * 0.453592;
            Console.WriteLine($"Weight: {pounds} lbs = {kilograms} kg");

            Console.WriteLine("========================================");

            // Converts miles to kilometers
            Console.Write("Enter distance in miles(mi): ");
            double miles = Convert.ToDouble(Console.ReadLine());
            double kilometers = miles * 1.60934;
            Console.WriteLine($"Distance: {miles} mi = {kilometers} km");

            Console.WriteLine("========================================");

            // Converts Fahrenheit to Celsius
            Console.Write("Enter temperature in Fahrenheit(°F): ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Temperature: {fahrenheit} °F = {celsius} °C");

            Console.WriteLine("========================================");

            // Calculates the average age of students
            int totalAges = 0;
            int[] studentAges = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter age of student {i + 1}: ");
                studentAges[i] = Convert.ToInt32(Console.ReadLine());
                totalAges += studentAges[i];
            }
            double averageAge = (double)totalAges / 10;
            Console.WriteLine($"Ages of students: {string.Join(", ", studentAges)}\nAverage Age: {averageAge:F2}");

            Console.WriteLine("========================================");

            // Avengers Fantasy Story
            string character1 = "Natasha Romanoff";
            string character2 = "Bruce Banner";
            string character3 = "Tony Stark";
            string character4 = "Steve Rogers";
            string character5 = "Clint Barton";

            string equipment1 = "Fighting Skills";
            string equipment2 = "The Hulk";
            string equipment3 = "The Iron Man Suit";
            string equipment4 = "The Captain America Shield";
            string equipment5 = "Bow and Arrow";

            string story = $@"
            The Earth's mightiest heroes teamed up to stop a dark force from enslaving humanity:
            - {character1}, an assasin, using her incredible {equipment1}.
            - {character2}, the human, transforming into {equipment2}.
            - {character3}, the genius billionaire, wearing {equipment3}.
            - {character4}, the supper soldier, using his frisbee {equipment4}.
            - {character5}, another assasin, with his {equipment5}.
            They defended New York from the destruction that the dark force was upon it, 
            and finally peace was brought back.
            ";

            Console.WriteLine(story);

            Console.WriteLine("=================================================================");

            //PART 2
            Console.WriteLine("PART 2:");

            // Right Triangle
            Console.WriteLine("A");

            Console.Write("Enter a positive integer: ");

            if (int.TryParse(Console.ReadLine(), out int Input1) && Input1 > 0)
            {
                for (int i = 1; i <= Input1; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{j} ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("========================================");

            //Addition
            Console.WriteLine("B");

            Console.Write("Enter a positive integer: ");

            if (int.TryParse(Console.ReadLine(), out int Input2) && Input2 > 0)
            {
                int sum = 0;

                for (int i = 1; i <= Input2; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"Input: {Input2}");
                Console.WriteLine($"Formula: 1+2+...+{Input2}");
                Console.WriteLine($"Output: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("========================================");

            //Third Experiment
            Console.WriteLine("C");

            Console.Write("Enter a positive integer: ");

            if (int.TryParse(Console.ReadLine(), out int Input3) && Input3 > 0)
            {
                for (int i = Input3; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{j} ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
