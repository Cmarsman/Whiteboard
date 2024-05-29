using System.ComponentModel.Design;

namespace Whiteboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(10));
        }
        public static string FizzBuzz(int num) 
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "fizzbuzz";
            }
            else if (num % 3 == 0)
            {
                return "fizz";
            }
            else if (num % 5 == 0)
            {
                return "buzz";
            }
            else 
            {
                return num.ToString();
            }
            

        }

    }
}
