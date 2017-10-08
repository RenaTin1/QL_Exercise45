using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise45
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                //Serena Tindle-- Exercise45 (Area and Perimeter of a rectangle)
                //TODO
                //Fix validation method error

                bool ContinueProgram = true;
                while (ContinueProgram == true)
                {

                    Square RectangleLength = new Square(); //create an object

                    Console.WriteLine("Enter a side length:"); //prompt
                    RectangleLength.SideLength = ReadValidDouble(); //feed object
                    Console.WriteLine("The square has a side length of" + "Its area is" + RectangleLength.GetArea() + "and its perimeter is" + RectangleLength.GetPerimeter());

                    string UserOption; //Continue program or exit?
                    Console.WriteLine("Would you like to continue? (y/n)");
                    UserOption = Console.ReadLine();

                    if (UserOption == "N" || UserOption == "No" || UserOption == "no" || UserOption == "n")
                    {
                        ContinueProgram = false;
                        Console.WriteLine("Goodbye!");
                    }

                    Console.ReadKey();
                }
            }

            public static double ReadValidDouble() //method for validation 
            {
                double.Parse(Console.ReadLine());
                double input = 0;

                while (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Please enter valid data");
                }
                return input;

            }
        }
    }
}
