using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConvert.Test
{
    [TestClass]
    public class Test_Float
    {
        [TestMethod]
        public void Float_AsFloat_FromFloat()
        {
            Assert.AreEqual((float)100.1001, ((float)100.1001).AsFloat());
        }
    }
}
