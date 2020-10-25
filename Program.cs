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
            //Comparing the distances of two lines
            //the result gives 0 if both are equal and -1 if first one is less than second
            //+1 if first one is greater than second one 
            int compare = result1.CompareTo(result2);

            if (compare == 0)
            {
                Console.WriteLine("Lines are equal");
            }
            else if (compare == -1)
            {
                Console.WriteLine("First line is less than second line");
            }
            else
            {
                Console.WriteLine("First line is greater than second line");
            }
        }
    }
}
