using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            //Arrange
            var vendor = new Vendor();
            vendor.VendorId = 1;
            vendor.CompanyName = "ABC Corp";
            var expected = "Vendor: ABC Corp (1)";

            //Act
            var actual = vendor.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SendMailTest()
        {
            //Arrange
            var vendorRepository = new VendorRepository();
            var vendors = vendorRepository.Retrieve();
            var expected = new List<string>()
            {
                "Message sent: Important message for: ABC Corp",
                "Message sent: Important message for: XYZ Inc"
            };

            //Act
            var actual = Vendor.SendEmail(vendors, "Test message");

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}