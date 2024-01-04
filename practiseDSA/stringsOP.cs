using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiseDSA
{
    public class stringsOP
    {
        //In C#, string is keyword which is an alias for System.String class.
        //That is why string and String are equivalent.
        //We are free to use any naming convention.
        string testName = "Test"; //creating string using string keyword
        String testDescsrption = "Test Description";//creating string using String class  

        static char[] ch = { 'c', 's', 'h', 'a', 'r', 'p' };
        string testTest = new string(ch);

        public string reverseString1(string problem)
        {
            char[] reversedStringChars = new char[problem.Length];
            int j = 0;
            for (int i = problem.Length - 1; i >= 0; i--)
            {
                reversedStringChars[j] = problem[i];
                j++;
            }

            return new string(reversedStringChars);
        }

        public string reverseString2(string problem)
        {
            string solution = string.Empty;
            for (int i = problem.Length - 1; i >= 0; i--)
            {
                solution += problem[i];

            }
            return solution;
        }

        public string reverseString3(string problem)
        {
            string solution = string.Empty;
            foreach (var item in problem)
            {
                solution = item + solution;
            }
            return solution;
        }

        public bool isStringPalindrom1(string problem)
        {
            bool isPalindrom = false;
            if (problem == reverseString2(problem))
            {
                isPalindrom = true;
            }
            return isPalindrom;
        }

        public bool isStringPalindrom2(string problem)
        {
            bool isPalindrom = true;

            int firstpointer = 0;
            int lastpointer = problem.Length-1;
            while (firstpointer < lastpointer)
            {
                if (problem[firstpointer] != problem[lastpointer])
                {
                    isPalindrom = false;
                }
                firstpointer++;
                lastpointer--;
                
            }

            return isPalindrom;
        }

        public Hashtable getWordsCount(string sentence)
        {
            Hashtable ht = new Hashtable();
            string[] sentenceArray = sentence.Split();

            foreach (string item in sentenceArray)
            {
                if (!ht.ContainsKey(item))
                {
                    ht.Add(item, 1);

                }
                else if (ht.ContainsKey(item))
                {
                    ht[item] = (int)ht[item] + 1;
                }
            }

            return ht;
        }
    }

}