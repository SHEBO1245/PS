using PS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{ 

    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        IEnumerable<int> evenNumbers = numbers.Is_Even( N => N % 2 == 0);
        
        foreach (var num in evenNumbers)
        {
            Console.Write(num + " ");
        }
        Console.Write("Hello world");
        Console.Write("Hello world");
        Console.Write("Hello world");
        //
        //

        //
    }
}