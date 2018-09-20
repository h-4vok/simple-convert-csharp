using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConvert.Test
{
    [TestClass]
    public class Test_Decimal
    {
        [TestMethod]
        public void Decimal_AsDecimal_FromDecimal()
        {
            Assert.AreEqual((decimal)100.100, ((decimal)100.100).AsDecimal());
        }
    }
}
