using System;
using ProjectLibrary;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter BS - Basic Salary ");
                double bS = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter CS - Current Salary ");
                double cS = double.Parse(Console.ReadLine());
                Actions action = new Actions(new Data(bS, cS));
                action.Show();
            }
            catch (FormatException) { }
            Console.ReadKey();
        }
    }
}
