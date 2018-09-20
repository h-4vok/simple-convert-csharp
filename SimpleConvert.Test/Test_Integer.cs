using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConvert.Test
{
    [TestClass]
    public class Test_Integer
    {
        [TestMethod]
        public void Integer_AsInt_FromInt()
        {
            Assert.AreEqual(400, 400.AsInt());
        }
    }
}
