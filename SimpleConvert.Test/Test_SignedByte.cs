using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConvert.Test
{
    [TestClass]
    public class Test_SignedByte
    {
        [TestMethod]
        public void SignedByte_AsSByte_FromSByte()
        {
            Assert.AreEqual((sbyte)100, ((sbyte)100).AsSByte());
        }
    }
}
