using System;

namespace csharpconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName,lastName;
            Console.WriteLine("Enter your Firstname!");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Lastname");
            lastName = Console.ReadLine();
            Console.Write("your Fullname is  {0} {1}", firstName,lastName);

        }
    }
}
