using NUnit.Framework;

namespace NUnitHandsOn
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(2,2,4)]
        [TestCase(0,0,2)]
        public void Add(int firstNumber, int secondNumber,int exp)
        {
            if (firstNumber > 0 && secondNumber > 0)
            {
                int r = firstNumber + secondNumber;
                Assert.That(r,Is.EqualTo(exp));
            }
        }

    }
}