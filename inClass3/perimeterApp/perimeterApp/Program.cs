/* 
 * Program ID: inClass3
 * 
 * Program Authors:
 *      
 *      Hyunjin Kim
 *      Yusuf Hafeji
 * 
 * 
 * Revision History:
 *      created Oct 3, 2021 by Hyunjin Kim
 *      revised Oct 6, 2021 by Yusuf Hafeji
 *      
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perimeterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a variable
            int num;

            // Ask the user which shape they want to find the perimeter for
            Console.WriteLine("Enter a number of the shape: Square = 1, Rectangle = 2, Triangle = 3");
            num = Convert.ToInt32(Console.ReadLine());

            // Switch statement containing the rest of the code excpet for the methods
            switch (num)
             {
                 case 1:
                     Console.WriteLine("enter a side of the square(1 side): "); // Ask for the length of the side(s)
                     int squareSide1 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("The perimeter of the selected shape is: " + PerimeterShape(squareSide1));
                     break;

                 case 2:
                     Console.Write("enter a side of the rectangle(2 sides, press enter): "); // Ask for the length of the side(s)
                    int rectangleSide1 = Convert.ToInt32(Console.ReadLine());
                     int rectangleSide2 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("The perimeter of the selected shape is: " + PerimeterShape(rectangleSide1, rectangleSide2));
                     break;

                 case 3:
                     Console.WriteLine("enter a side of the triangle(3 sides, press enter): "); // Ask for the length of the side(s)
                    int triangleSide1 = Convert.ToInt32(Console.ReadLine());
                     int triangleSide2 = Convert.ToInt32(Console.ReadLine());
                     int triangleSide3 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("The perimeter of the selected shape is: " + PerimeterShape(triangleSide1, triangleSide2, triangleSide3));
                     break;

                 default:
                     Console.WriteLine("enter a number 1 to 3");
                     break;
        }

        }

        static int PerimeterShape (int a) // square
        {
            int squarePerimeter = 4 * a;
            return squarePerimeter;
        }
        static int PerimeterShape(int a, int b) // rectangle
        {
            int rectanglePerimeter = 2 * (a + b);
            return rectanglePerimeter;
        }
        static int PerimeterShape(int a,int b,int c) // triangle
        {
            int trianglePerimeter = a + b + c;
            return trianglePerimeter;
        }
    }
}
