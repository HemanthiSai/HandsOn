using NUnit.Framework;

namespace NUnitHandsOn2
{
    [TestFixture]
    public class Tests
    {
        string Name;
        string Email;
        [SetUp]
        public void Author()
        {
            Name = "CTS";
            Email = "CTS@gmail.com";
            Assert.AreEqual("CTS", Name);
            Assert.AreEqual("CTS@gmail.com", Email);
        }

        [Test,Order(1)]
        [TestCase(2,2,4)]
        public void Add(int firstNumber, int secondNumber, int exp)
        {
                int r = firstNumber + secondNumber;
                Assert.That(r, Is.EqualTo(exp));
        }
        [Test, Order(2)]
        [TestCase(2, 1, 1)]
        public void Sub(int firstNumber, int secondNumber, int exp)
        {
            int r = firstNumber - secondNumber;
            Assert.That(r, Is.EqualTo(exp));
        }
        [Test, Order(3)]
        [TestCase(2, 2, 4)]
        public void Mul(int firstNumber, int secondNumber, int exp)
        {
            int r = firstNumber * secondNumber;
            Assert.That(r, Is.EqualTo(exp));
        }
        [Test, Order(4)]
        [TestCase(2, 1, 2)]
        [Ignore("Don't run this test as duplicate")]
        public void Div(int firstNumber, int secondNumber, int exp)
        {
            int r = firstNumber / secondNumber;
            Assert.That(r, Is.EqualTo(exp));
        }

    }
}