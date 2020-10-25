using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionUsingOOPS
{
    class LineComparisionImpl
    {
        /// <summary>
        /// Gets the end points difference power of x-Coordinates.
        /// </summary>
        /// <returns></returns>
        public double GetEndPointsOfX()
        {
            Console.WriteLine("Enter x1,x2");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var x2 = Convert.ToDouble(Console.ReadLine());

            return Math.Pow((x2 - x1), 2);
        }
        /// <summary>
        /// Gets the end points difference power of y-Coordinates.
        /// </summary>
        /// <returns></returns>
        public double GetEndPointsOfY()
        {
            Console.WriteLine("Enter y1,y2");
            var y1 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());

            return Math.Pow((y2 - y1), 2);
        }
        /// <summary>
        /// Computation of lenght of line using distances the BTWN points formula
        /// using endpoints difference square values of x and y
        /// </summary>
        /// <param name="temp1">The temp1.</param>
        /// <param name="temp2">The temp2.</param>
        /// <returns></returns>
        public double DistanceBtwnPoints(double temp1, double temp2)
        {
            return Math.Sqrt(temp1 + temp2);
        }
    }
}
