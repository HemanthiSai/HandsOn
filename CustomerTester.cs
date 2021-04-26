using CustomerCommLib;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerComm
{
    [TestFixture]
    public class CustomerTester
    {
        [Test]
        [TestCase]
        public void TestSMTPService()
        {
            var smtp = new Mock<IMailSender>();
            smtp.Setup(x => x.SendMail("CTS20DN005@gmail.com", "Welcome User")).Returns(true);
            CustomerCommLib.CustomerCom component = new CustomerCommLib.CustomerCom(smtp.Object);
            Assert.AreEqual(true, component.SendMailToCustomer());
        }
    }
}
