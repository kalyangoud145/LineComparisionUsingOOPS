using System;

namespace LineComparisionUsingOOPS
{
    class Program
    {
        /// <summary>
        /// Main class for calling methods for computing line length
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            LineComparisionImpl lineComparisionImpl = new LineComparisionImpl();
            double temp1 = lineComparisionImpl.GetEndPointsOfX();
            double temp2 = lineComparisionImpl.GetEndPointsOfY();
            double result1 = lineComparisionImpl.DistanceBtwnPoints(temp1, temp2);
            Console.WriteLine("Distance between two points: " + result1);
        }
    }
}
