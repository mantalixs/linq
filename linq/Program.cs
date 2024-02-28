using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        
        List<int> list = new List<int> { 3, 8, 12, 6, 9, 18, 5, 14 };

        double average = list.Where(t => t >= 5 && t <= 15).Average();

        Console.WriteLine($"Середнє арифметичне елементів у діапазоні [5, 15]: {average}");
    }
}