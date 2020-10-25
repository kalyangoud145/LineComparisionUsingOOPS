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
            double temp3 = lineComparisionImpl.GetEndPointsOfX();
            double temp4 = lineComparisionImpl.GetEndPointsOfY();
            double result2 = lineComparisionImpl.DistanceBtwnPoints(temp3, temp4);
            Console.WriteLine("Distance between two points: " + result2);
            bool checkLines = result1.Equals(result2);
            if (checkLines == true)
            {
                Console.WriteLine("Both lines are equal");
            }
            else
            {
                Console.WriteLine("lines are not equal");
            }
        }
    }
}
