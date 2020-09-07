using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello RoadToGlobal");

            Console.WriteLine("Enter your age:");
           
            var age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Your age is: " + age);

            Console.WriteLine("Enter name:");

            var Name = Console.ReadLine();

            Console.WriteLine("Your name is: " + Name);

            Console.WriteLine("Are you alive " + Name + "?");

            var alive = Console.ReadLine();

            Console.WriteLine("Alive: " + alive);

        }
    }
}