using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibHandsOn1
{
    [TestFixture]
    public class TestCompare
    {
        MathComp comp;
        private static IEnumerable<TestCaseData> CompareTwoNumberTestData
        {
            get
            {
                yield return new TestCaseData(-1, 0, 0);
                yield return new TestCaseData(2, 1, 1);
                yield return new TestCaseData(-1, 2, -1);
            }
        }
        [Test]
        [TestCaseSource(nameof(CompareTwoNumberTestData))]
        [TestCase(3, 2, 0)]
        [TestCase(4, 3, 1)]
        public void Compare(int a, int b, int expected)
        {
            comp = new MathComp();
            int output = comp.CompareTwoNumbers(a, b);
            Assert.That(output, Is.EqualTo(expected));
        }
        [Test]
        public void Test_Divider()
        {
            comp = new MathComp();
            Assert.Throws<DivideByZeroException>(() => comp.Divide(5, 0));
        }
    }
}
