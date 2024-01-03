using Microsoft.VisualStudio.TestTools.UnitTesting;
using practiseDSA;
using System;
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
        [TestMethod()]
        public void reverseString()
        {
            stringsOP sOP = new stringsOP();
            string name = "Hello";
            Assert.AreEqual("olleH",sOP.reverseString1(name));
            Assert.AreEqual("olleH", sOP.reverseString2(name));
            Assert.AreEqual("olleH", sOP.reverseString3(name));
        }

        
    }
}