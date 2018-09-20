using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConvert.Test
{
    [TestClass]
    public class Test_SignedShort
    {
        [TestMethod]
        public void SignedShort_AsUShort_FromUShort()
        {
            Assert.AreEqual((ushort)100, ((ushort)100).AsUShort());
        }
    }
}
