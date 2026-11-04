using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        void  NaturalNumbers(int n)
        {
            for (int i = 0; i < n ; i++)
            {
                Console.WriteLine(i);
            }

        }

        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine($"{NaturalNumbers}");
    }
}