﻿// See https://aka.ms/new-console-template for more information



class Program
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int dayNumber = int.Parse(Console.ReadLine());

        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }
    }
}