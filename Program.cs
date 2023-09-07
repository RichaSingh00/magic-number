using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = 7; //basically using a named variable is better to understand the code and
            //usage of the number. 
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == magicNumber)
            {
                Console.WriteLine("Congratulations! You found the magic number!");
            }
            else
            {
                Console.WriteLine("Sorry, try again!");
            }
        }
    }
}

