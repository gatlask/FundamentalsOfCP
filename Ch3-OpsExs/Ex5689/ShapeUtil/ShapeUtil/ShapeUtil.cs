using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeUtil
{
    class ShapeUtil
    {
        static void Main(string[] args)
        {

            //Ex5 Calculate area of Trapezium
            double a, b, h;
            a = 11; b = 12; h = 5;

            // area of the trapezoid is 
       //     area = (a+b)*h/2;
            Console.WriteLine($"The Area is {(a + b) * h / 2.0}");


            //Ex6 Calculate area and Perimeter of Rectangle
            //double a, b;
            Console.WriteLine($"Area of Rectangle with sides a nd b {a * b}");
            Console.WriteLine($"The Perimeter value is {2 * (a + b)}");


            //Ex8 Check if point p is within the circle
            double x, y;
            x = 2.5f; y = 2.7f;
            //input
            Console.WriteLine("Please enter a point coordinates x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter coordinates y ");
            y = Convert.ToDouble(Console.ReadLine());

            // circle is at 0,0 radius is 5
            //calculate point distance from the circle center
            double dist = Math.Sqrt(x * x + y * y);

            // check the value with radius and print the result
            Console.WriteLine($" The point is in the circle {(5 > dist)}");

            //Ex9
            //within the circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]
            if ((5 > dist) && (x < -1 || x > 5) && (y < 1 || y > 5))
            {
                Console.WriteLine("Point is in the Circle and outside the rectangle");
            }

            Console.ReadKey();

        }
    }
}
