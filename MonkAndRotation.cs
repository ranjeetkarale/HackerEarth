using System;
using System.Collections.Generic;
using System.Linq;

namespace MonkAndRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int NrOfTestCases = Convert.ToInt32(Console.ReadLine());
            while (NrOfTestCases > 0)
            {
                NrOfTestCases--;
                string inputLine = Console.ReadLine();
                {
                    string[] inputValue = inputLine.Split(' ');
                    int NrOfArrayElements = Convert.ToInt32(inputValue[0]);
                    int NrOfStepsToRoate = Convert.ToInt32(inputValue[1]);

                    string inputArray = Console.ReadLine();

                    string[] arrayElelments = inputArray.Split(' ');

                    string[] temp1 = null ;
                    string[] temp2 = null;

                    temp1 = new string[NrOfArrayElements];
                    temp2 = new string[NrOfArrayElements];
                    if (NrOfStepsToRoate > NrOfArrayElements)
                    {
                       NrOfStepsToRoate= NrOfStepsToRoate % NrOfArrayElements;
                       
                       temp1 = arrayElelments.Take(arrayElelments.Length - NrOfStepsToRoate).ToArray();
                       temp2 = arrayElelments.Skip(arrayElelments.Length - NrOfStepsToRoate).Take(NrOfStepsToRoate).ToArray();
                       arrayElelments = temp2.Concat(temp1).ToArray();
                    }
                    else
                    {


                        temp1 = arrayElelments.Take(arrayElelments.Length - NrOfStepsToRoate).ToArray();
                        temp2 = arrayElelments.Skip(arrayElelments.Length - NrOfStepsToRoate).Take(NrOfStepsToRoate).ToArray();
                        arrayElelments = temp2.Concat(temp1).ToArray();
                    }
                    Console.WriteLine(string.Join(" ", arrayElelments));
                }
            }
           // Console.ReadLine();

        }
    }
}
