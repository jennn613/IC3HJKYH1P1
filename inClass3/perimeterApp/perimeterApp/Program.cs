/* 
 * Program ID: inClass3
 * 
 * Program Authors:
 *      
 *      Hyunjin Kim
 * 
 * 
 * Revision History:
 *      created Oct 3, 2021 by Hyunjin Kim
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
            int num;

            Console.WriteLine("Enter a number of the shape: Square = 1, Rectangle = 2, Triangle = 3");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
             {
                 case 1:
                     Console.WriteLine("enter a side of the square(1 side): ");
                     int sside1 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("The perimeter of the selected shape is: " + PerimeterShape(sside1));
                     break;

                 case 2:
                     Console.Write("enter a side of the rectangle(2 sides, press enter): ");
                     int rside1 = Convert.ToInt32(Console.ReadLine());
                     int rside2 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("The perimeter of the selected shape is: " + PerimeterShape(rside1, rside2));
                     break;

                 case 3:
                     Console.WriteLine("enter a side of the triangle(3 sides, press enter): ");
                     int tside1 = Convert.ToInt32(Console.ReadLine());
                     int tside2 = Convert.ToInt32(Console.ReadLine());
                     int tside3 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("The perimeter of the selected shape is: " + PerimeterShape(tside1, tside2, tside3));
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
