using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CertificateAgent.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CertificateAgent.Tests
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void ListOnlyValids()
        {
            Assert.IsNotNull(DigitalCertificateAgent.ListOnlyValidCerticates());
        }

        [TestMethod]
        public void ListOnlyValidsForTestsPurposes()
        {
            Assert.IsNotNull(DigitalCertificateAgent.ListOnlyValidCerticatesForTestsPurposes());
        }
    }
}
