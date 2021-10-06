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

            int num;

            Console.WriteLine("Enter a number for a shape. Enter 1 for a square, 2 for a rectangle, and 3 for a triangle: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Please enter the length of the square side: ");
                    int squareLength = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The perimeter of the selected shape is: " + PerimeterShape(squareLength));
                    break;

                case 2:
                    Console.WriteLine("Please enter the length of one of the rectangle sides: ");
                    int rectangleLength1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please eneter the length of the other rectangle side: ");
                    int rectangleLength2 = Convert.ToInt32(Console.ReadLine());
                    break;

                case 3:
                    Console.WriteLine("Please enter the length of one of the triangle sides: ");
                    int triangleLength1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the length of one of the other triangle sides: ");
                    int triangleLength2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the length of the last triangle side: ");
                    int triangleLength3 = Convert.ToInt32(Console.ReadLine());
                    break;
            }
            

        }
        static int PerimeterShape(int a)
        {

        }

        static int PerimeterShape(int a, b)
        {

        }

        static int PerimeterShape(int a, b, c)
        {

        }
    }
}
