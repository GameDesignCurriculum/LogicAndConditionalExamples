using System;
namespace BooleanVariables
{
    public static class ComparisonOperators
    {
        public static void Activity2()
        {
            double timeToDinner = 4;
            double distance = 95;
            double rate = 30;

            double tripDuration = distance / rate;

            bool answer = tripDuration <= timeToDinner;

            Console.WriteLine(answer);
        }
    }
}

