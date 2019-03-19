using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to week2");
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello {0}", name);

            Console.Write("Could you please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write($"Ok {name}, could you please enter your gender: ");
            string gender = Console.ReadLine();

            Console.Write("Please enter your address: ");
            string address = Console.ReadLine();

            Console.Clear();
        }
    }
}
