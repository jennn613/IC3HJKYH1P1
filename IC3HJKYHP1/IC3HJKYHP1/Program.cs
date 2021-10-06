/* 
 * Program ID: inClass3
 * 
 * Program Authors:
 *      Yusuf Hafeji
 *      Hyunjin Kim
 * 
 * 
 * Revision History:
 *      created Oct 6, 2021 by Yusuf Hafeji, Hyunjin Kim
 *      
 */

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace inClass3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for a shape. Enter 1 for a square, 2 for a rectangle, and 3 for a triangle: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Please enter the length of the square side: ");
                int squareLength = Convert.ToInt32(Console.ReadLine());
                int finalSqarePerimeter =  PerimeterShape(squareLength);
                Console.WriteLine("The perimter of the square is " + finalSqarePerimeter);
            }
            else if (num == 2)
            {
                Console.WriteLine("Please enter the length of one of the rectangle sides: ");
                int rectangleLength1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please eneter the length of the other rectangle side: ");
                int rectangleLength2 = Convert.ToInt32(Console.ReadLine());
                int finalRectanglePerimeter = PerimeterShape(rectangleLength1, rectangleLength2);
                Console.WriteLine("The perimeter of the rectangle is " + finalRectanglePerimeter);
            }
            else if (num == 3)
            {
                Console.WriteLine("Please enter the length of one of the triangle sides: ");
                int triangleLength1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the length of one of the other triangle sides: ");
                int triangleLength2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the length of the last triangle side: ");
                int triangleLength3 = Convert.ToInt32(Console.ReadLine());
                int finalTrianglePerimeter = PerimeterShape(triangleLength1, triangleLength2, triangleLength3);
                Console.WriteLine("The perimter of the rectangle is " + finalTrianglePerimeter);
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 3.");
            }
        }
        static int PerimeterShape(int a)
        {
            int squarePermineter = a * 4;
            return squarePermineter;
        }

        static int PerimeterShape(int a, int b)
        {
            int rectanglePerimeter = (a + b) * 2;
            return rectanglePerimeter;
        }

        static int PerimeterShape(int a, int b, int c)
        {
            int trianglePerimeter = a + b + c;
            return trianglePerimeter;
        }
    }
}