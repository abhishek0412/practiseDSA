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
        [TestMethod()]
        public void findLargetsInArrayTest()
        {
            arrayOP aOP = new arrayOP();
            Assert.AreEqual(99, aOP.findLargetsInArray(new int[] { 2, 8, 2, 1, 4, 9, 4, 3, 66, 99, 33, 23 }));
            Assert.AreEqual(66, aOP.findSecondLargetsInArray(new int[] { 2, 8, 2, 1, 4, 9, 4, 3, 66, 99, 33, 23 }));

        }

        [TestMethod()]
        public void findMissingNumberTest()
        {
            arrayOP aOP = new arrayOP();
            Assert.AreEqual(5, aOP.findMissingNumber(new int[] { 1,2,3,4,6,7 }));
            Assert.AreEqual(3, aOP.findMissingNumber(new int[] { 1, 2, 4, 6, 7,5 }));
        }
    }
}