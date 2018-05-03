using NUnit.Framework;
using Source;

namespace Tests
{
    [TestFixture]
    public class Fixture
    {
        [Test]
        public void ReturnFalseGivenValueOf1()
        {
            Assert.That(Program.Solve(), Is.EqualTo(5));
        }
    }
}
