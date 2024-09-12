using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyMenuSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
        }
        
        // Write a program that will display a menu with least 6 options plus exit
        //Each option should call a different subroutine,
        //2 of which need to include parameters.
        //The program should run until the user choses the option to exit.
      
        static void DisplayMenu()
        {
            // Example Menu
            Console.WriteLine("1. Add a new item");
            Console.WriteLine("2. Remove an item");
            Console.WriteLine("3. Display all items");
            Console.WriteLine("4. Exit");
        }
    }
}
