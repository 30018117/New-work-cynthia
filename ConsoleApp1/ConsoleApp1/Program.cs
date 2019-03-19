using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static string fullName;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Week2");

            Console.Write("Task 1 - Please enter your name: ");


            string name = Console.ReadLine();




            Console.WriteLine("Hello {0}", name);

            Console.Write("Could you please enter your age: ");
            int age = int.Parse(Console.ReadLine());


            Console.Write($"Ok {name}, could you please enter your gender: ");
            string gender = Console.ReadLine();


            Console.Write("Please enter your address: ");
            string address = Console.ReadLine();


            Console.WriteLine("Ok, here is the information that i gathered:");

            Console.WriteLine("Name: {0}", name);

            Console.WriteLine("Age: {0}", age);

            Console.WriteLine("Gender: {0}", gender);

            Console.WriteLine("Address: {0}", address);


            Console.WriteLine("Task 1 complete - Press enter to continue...");

            Console.ReadLine();

            Console.Clear();


            Console.WriteLine("Task 3 - Please enter a number: ");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number: ");

            int num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));


            Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));


            Console.WriteLine("{0} x {1} = {2}", num1, num2, (num1 * num2));


            Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));

            Console.WriteLine("Task 2 complete - Press enter to continue...");

            Console.ReadLine();

            Console.Clear();

            Console.Write("Task 3 - Please enter your first name: ");

            string fname = Console.ReadLine();

            Console.Write("Please enter your second name: ");

            Console.WriteLine("Hello " + fullName);//concantination

            Console.WriteLine("Task 3 complete - Press enter to exit the application...");

            Console.ReadLine();
        }
    }
}
