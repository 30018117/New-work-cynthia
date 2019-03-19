using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3 - Please enter a number; ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));

            Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));

            Console.WriteLine("{0} x {1} = {2}", num1, num2, (num1 * num2));

            Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));

            Console.WriteLine("Task 2 compleat - Press enter to continue...");
            Console.ReadLine();

            Console.Clear();



        }
    }
}
