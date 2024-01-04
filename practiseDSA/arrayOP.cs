using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiseDSA
{
    public class arrayOP
    {

        public int findLargetsInArray(int[] problem)
        {
            if (problem == null || problem.Length == 0)
            {
                throw new ArgumentException("Array is null or empty.");
            }
            int solution = problem[0];

            foreach(int i in problem)
            {
                if (i > solution)
                {
                    solution = i;
                }
            }

            return solution;
        }


        public int findSecondLargetsInArray(int[] problem)
        {
            if (problem == null || problem.Length < 2)
            {
                throw new ArgumentException("Array is null or empty.");
            }
            int largest = problem[0];
            int secondLargest = problem[0];
            
            foreach (int i in problem)
            {
                if (i > largest)
                {
                    secondLargest = largest;
                    largest = i;                  
                }
                else if (i > secondLargest && i != largest)
                {
                    secondLargest = i;
                }

            }

            return secondLargest;
        }

        public int findMissingNumber(int[] problem) 
        {
            if (problem == null || problem.Length < 2)
            {
                throw new ArgumentException("Array is null or empty.");
            }
            int n = problem.Length+1;

            int expectedSum = (n * (n + 1)) / 2;

            int actualSum = 0;

            foreach (int item in problem)
            {
                actualSum = item + actualSum;
            }

            return expectedSum - actualSum;

        }
    }
}
