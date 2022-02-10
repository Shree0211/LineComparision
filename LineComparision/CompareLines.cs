using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class CompareLines
    {
        // Structure to describe a geometry point
        struct Point
        {
            // (x, y) Coordinates of a point
            public int x;
            public int y;

            // Sets the values for the point
            public void Set(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            // Displays the info on the point
            public void Describe()
            {
                Console.WriteLine("x: " + x + ", y: " + y);
            }
        }

        // Declared 2 Point objects for the end points of a line
        private Point point1 = new Point();
        private Point point2 = new Point();

        // Declared length variable that stores the length of the line
        private double length;

        // Default constructor
        public CompareLines()
        {
            point1.Set(0, 0);
            point2.Set(0, 0);
            length = 0;
        }

        // This constructor is invoked when parameters are passed
        public CompareLines(int x1, int y1, int x2, int y2)
        {
            SetPoints(x1, y1, x2, y2);
        }

        // Calculate length of line from the points
        private void CalculateLength()
        {
            int xDifference = point1.x - point2.x;
            int yDifference = point1.y - point2.y;
            length = Math.Sqrt(Math.Pow(xDifference, 2) + Math.Pow(yDifference, 2));
        }

        /*// Get length
        public double Length()
        {
            return length;
        }*/

        // Displays the info of the line
        public void Describe()
        {
            Console.WriteLine("Line info: ");
            Console.WriteLine("Point 1: ");
            point1.Describe();
            Console.WriteLine("Point 2: ");
            point2.Describe();
            Console.WriteLine("Length: " + length + "\n");
        }

        // Sets the values for the 2 points and finds the length
        public void SetPoints(int x1, int y1, int x2, int y2)
        {
            point1.Set(x1, y1);
            point2.Set(x2, y2);
            CalculateLength();
        }

        // Get points from user
        public void GetPointsFromUser()
        {
            int x1, y1, x2, y2;
            Console.WriteLine("Enter Values for point 1: ");
            Console.Write("x: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Values for point 2: ");
            Console.Write("x: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            SetPoints(x1, y1, x2, y2);
        }

        public void Compare(CompareLines line)
        {
            if (this.length == line.length)
                Console.WriteLine("The lines are of equal length");
            else
                Console.WriteLine("The lines are of different lengths");
        }
    }
}