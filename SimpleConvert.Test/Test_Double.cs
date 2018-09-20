using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConvert.Test
{
    [TestClass]
    public class Test_Double
    {
        [TestMethod]
        public void Double_AsDouble_FromDouble()
        {
            Assert.AreEqual((double)100.1001, ((double)100.1001).AsDouble());
        }
    }
}
