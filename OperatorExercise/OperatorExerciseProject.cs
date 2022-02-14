using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition operator example:
            int resultAdd;
            int addA = 66;
            int addB = 4;

            resultAdd = addA + addB;

            Console.WriteLine(resultAdd);

            //Subtraction operator example:
            int resultSub;
            int subA = 3;
            int subB = 13;

            resultSub = subA - subB;

            Console.WriteLine(resultSub);

            //Multiplication operator example:
            int resultMult;
            int multA = 10;
            int multB = 4;

            resultMult = multA * multB;

            Console.WriteLine(resultMult);

            //Division & Modulus operators example:
            int divA = 17;
            int divB = 4;
            int quotient = divA / divB;
            int remainder = divA % divB;

            if (divA == 17 && divB == 4)
            {
                Console.WriteLine($"{divA}/{divB} is {quotient} remainder {remainder}.");
            }




            //-------------------------------
            //Exercise 2:
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double areaOfCircleResult = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {areaOfCircleResult}.");

            //-------------------------------
            //Though Exercise:
            //k = 16?
            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k);
        }

        //Area of Circle Method:
        public static double AreaOfCircle(double r)
        {
            double areaOfCircleResult = Math.PI * (Math.Pow(r, 2));
            return areaOfCircleResult;
        }
    }
}
