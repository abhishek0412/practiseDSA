using Microsoft.VisualStudio.TestTools.UnitTesting;
using practiseDSA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace practiseDSA.Tests
{
    [TestClass()]
    public class stringsOPTests
    {
        [TestMethod(), TestCategory("smoke")]
        public void reverseString()
        {
            stringsOP sOP = new stringsOP();
            string name = "Hello";
            Assert.AreEqual("olleH",sOP.reverseString1(name));
            Assert.AreEqual("olleH", sOP.reverseString2(name));
            Assert.AreEqual("olleH", sOP.reverseString3(name));
        }

        [TestMethod(), TestCategory("Acceptance")]
        public void isPalindrom()
        {
            stringsOP sOP = new stringsOP();

            Assert.IsTrue(sOP.isStringPalindrom1("radar"));

            Assert.IsFalse(sOP.isStringPalindrom1("abhishek"));

            Assert.IsTrue(sOP.isStringPalindrom2("radar"));

            Assert.IsFalse(sOP.isStringPalindrom2("abhishek"));
        }

        [TestMethod(), TestCategory("Acceptance")]
        public void countWords()
        {
            stringsOP sOP = new stringsOP();
            Hashtable hashtable = new Hashtable();
            hashtable = sOP.getWordsCount("This is a test for abhishek There are many words in here for test This is another test for abhishek with many words");

            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(hashtable[item] + " : " + item);
            }
        }
    }
}