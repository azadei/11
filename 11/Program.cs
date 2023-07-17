using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int> { 5, 7, 13, 24, 6, 9, 8, 7 };

       
        Console.Write("How many records you want to display? : ");
        int topCount = int.Parse(Console.ReadLine());

       
        Console.WriteLine("The top " + topCount + " records from the list are:");
        IEnumerable<int> topRecords = numbers.OrderByDescending(num => num).Take(topCount);
        foreach (int record in topRecords)
        {
            Console.WriteLine(record);
        }

    }
}
