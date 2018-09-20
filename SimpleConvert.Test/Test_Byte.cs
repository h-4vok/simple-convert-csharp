using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConvert.Test
{
	[TestClass]
    public class Test_Byte
    {
        [TestMethod]
        public void Byte_AsByte_FromByte()
        {
            Assert.AreEqual((byte)10, ((byte)10).AsByte());
        } 
    }
}
