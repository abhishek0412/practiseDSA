using Microsoft.VisualStudio.TestTools.UnitTesting;
using practiseDSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiseDSA.Tests
{
    [TestClass()]
    public class arrayOPTests
    {
        [TestMethod(),TestCategory("smoke")]
        public void findLargetsInArrayTest()
        {
            arrayOP aOP = new arrayOP();
            Assert.AreEqual(99, aOP.findLargetsInArray(new int[] { 2, 8, 2, 1, 4, 9, 4, 3, 66, 99, 33, 23 }));
            Assert.AreEqual(66, aOP.findSecondLargetsInArray(new int[] { 2, 8, 2, 1, 4, 9, 4, 3, 66, 99, 33, 23 }));

        }

        [TestMethod(), TestCategory("Acceptance")]
        public void findMissingNumberTest()
        {
            arrayOP aOP = new arrayOP();
            Assert.AreEqual(5, aOP.findMissingNumber(new int[] { 1,2,3,4,6,7 }));
            Assert.AreEqual(3, aOP.findMissingNumber(new int[] { 1, 2, 4, 6, 7,5 }));
        }

        [TestMethod(), TestCategory("smoke")]
        public void removeDuplicates()
        {
            arrayOP aOP = new arrayOP();
            int[] inputArray = new int[] { 1, 2, 3, 3, 6, 6, 7, 34 };
            int[] outputArray = new int[] { 1, 2, 3, 6, 7, 34 };
            CollectionAssert.AreEqual( outputArray, aOP.removeDuplicates(inputArray));
            //Assert.AreEqual(outputArray, aOP.removeDuplicates(inputArray));

            // In C#, when you use Assert.AreEqual to compare arrays, it checks whether the two arrays refer to the same instance, not whether their contents are equal.
            // To compare the contents of arrays, you should use CollectionAssert.AreEqual(if you're using MSTest) or Assert.IsTrue(expected.SequenceEqual(actual)):
            
            string[] inputStringArray = new string[] { "ram","lakhman","hanuman","ram","vishnu" };
            string[] outputStringArray = new string[] { "ram", "lakhman", "hanuman", "vishnu" };
            CollectionAssert.AreEqual(outputArray, aOP.removeDuplicates(inputArray));
        }

        [TestMethod(), TestCategory("Acceptance")]
        public void distinctDuplicates()
        {
            arrayOP aOP = new arrayOP();
            int[] inputArray = new int[] { 1, 2, 3, 3, 6, 6, 7, 34 };
            int[] outputArray = new int[] { 1, 2, 3, 6, 7, 34 };
            CollectionAssert.AreEqual(outputArray, aOP.removeDuplicates(inputArray));
            //Assert.AreEqual(outputArray, aOP.removeDuplicates(inputArray));

            // In C#, when you use Assert.AreEqual to compare arrays, it checks whether the two arrays refer to the same instance, not whether their contents are equal.
            // To compare the contents of arrays, you should use CollectionAssert.AreEqual(if you're using MSTest) or Assert.IsTrue(expected.SequenceEqual(actual)):

            string[] inputStringArray = new string[] { "ram", "lakhman", "hanuman", "ram", "vishnu" };
            string[] outputStringArray = new string[] { "ram", "lakhman", "hanuman", "vishnu" };
            CollectionAssert.AreEqual(outputArray, aOP.removeDuplicates(inputArray));
        }

        [TestMethod(), TestCategory("smoke")]
        public void sumAllNumbers()
        {
            arrayOP aOP = new arrayOP();
            Assert.AreEqual(23, aOP.sumAllNumbers(new int[] { 1, 2, 3, 4, 6, 7 }));
            Assert.AreEqual(25, aOP.sumAllNumbers(new int[] { 1, 2, 4, 6, 7, 5 }));
        }
    }
}