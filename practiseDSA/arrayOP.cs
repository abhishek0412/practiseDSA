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
    }
}
