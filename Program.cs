using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp__Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            Console.WriteLine("Enter Marks");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Enter marks in Subject " + (i + 1));
                marks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Marks List");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Subject {i + 1} \t Marks: {marks[i]}");
            }
            Console.ReadKey();
        }
    }
}
