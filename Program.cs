using System;
namespace Arrays
{
    class ArrayReview
    {
        static void Main(string[] args)
        {
            string[] coffee = { "Mocha", "Latte", "Matcha", "Americano" };
            int num;
            Console.Write("Enter Coffee Code: ");
            num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("You ordered: " + coffee[num]);
            
        }
    }
}
