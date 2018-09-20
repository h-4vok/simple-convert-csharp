using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConvert.Test
{
    [TestClass]
    public class Test_Long
    {
        [TestMethod]
        public void Long_AsLong_FromLong()
        {
            Assert.AreEqual((long)5000, ((long)5000).AsLong());
        }
    }
}
