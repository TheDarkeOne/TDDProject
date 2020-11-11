using NUnit.Framework;
using TDDProjectEuler;

namespace TDDProjectTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMultiple3Fizz()
        {
            EulerProblem1 euler = new EulerProblem1();
            string fizz = euler.GenerateFizzBuzz(3);
            Assert.AreEqual("Fizz", fizz);
        }

        [Test]
        public void TestMultiple5Buzz()
        {
            EulerProblem1 euler = new EulerProblem1();
            string fizz = euler.GenerateFizzBuzz(5);
            Assert.AreEqual("Buzz", fizz);
        }
    }
}