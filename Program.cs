using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string>();
	        Console.WriteLine("Please enter a name: ");
	        // Get a name from the console and assign it to a variable
	        string input = Console.ReadLine();
	        employees.Add(input);
	        for (int i = 0; i < employees.Count; i++) 
	      {
	        Console.WriteLine(employees[i]);
	      }
        }
    }
}
