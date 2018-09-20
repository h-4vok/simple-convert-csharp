using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleConvert.Test
{
    [TestClass]
    public class Test_Boolean
    {
        [TestMethod]
        public void Boolean_AsBool_FromBool()
        {
            Assert.IsTrue(true.AsBool());
            Assert.IsFalse(false.AsBool());
        }

        [TestMethod]
        public void Boolean_AsBool_FromBoolInObjectVar()
        {
            Assert.IsTrue(((object)true).AsBool());
            Assert.IsFalse(((object)false).AsBool());
        }

        [TestMethod]
        public void Boolean_AsBool_FromString()
        {
            Assert.IsTrue("true".AsBool());
            Assert.IsTrue("TRUE".AsBool());
            Assert.IsTrue("True".AsBool());
            Assert.IsTrue("tRUe".AsBool());

            Assert.IsFalse("false".AsBool());
            Assert.IsFalse("FALSE".AsBool());
            Assert.IsFalse("False".AsBool());
            Assert.IsFalse("fALSe".AsBool());
        }

        [TestMethod]
        public void Boolean_AsBool_FromString_InvalidCases()
        {
            Assert.ThrowsException<FormatException>(() => "".AsBool());
            Assert.ThrowsException<FormatException>(() => "hello".AsBool());
            Assert.ThrowsException<FormatException>(() => " ".AsBool());
            Assert.ThrowsException<FormatException>(() => "1".AsBool());
            Assert.ThrowsException<FormatException>(() => "0".AsBool());
        }

        [TestMethod]
        public void Boolean_AsBool_FromNumber()
        {
            Assert.IsTrue(1.AsBool());
            Assert.IsTrue(2.AsBool());
            Assert.IsTrue(200.AsBool());
            Assert.IsTrue((-1).AsBool());
            Assert.IsTrue((-2).AsBool());
            Assert.IsTrue((-200).AsBool());
            Assert.IsFalse(0.AsBool());
        }

        [TestMethod]
        public void Boolean_AsBool_InvalidCases()
        {
            //
        }
    }
}
