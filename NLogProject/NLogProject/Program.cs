using System;

namespace NLogProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition Problem \n Enter a, b Values");
            AddNumbers add = new AddNumbers();
            Console.WriteLine("Result is" + " "+add.Sum(0,1));
        }
    }
}
