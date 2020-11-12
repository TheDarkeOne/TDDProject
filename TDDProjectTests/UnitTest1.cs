using NUnit.Framework;
using TDDProjectEuler;

namespace TDDProjectTests
{
    public class Tests
    {
        EulerProblem1 euler;
        [SetUp]
        public void Setup()
        {
            euler = new EulerProblem1();
        }

        [Test]
        public void TestMultiple3Fizz()
        {
            string fizz = euler.GenerateFizzBuzz(3);
            Assert.AreEqual("Fizz", fizz);
        }

        [Test]
        public void TestMultiple5Buzz()
        {
            string buzz = euler.GenerateFizzBuzz(5);
            Assert.AreEqual("Buzz", buzz);
        }

        [Test]
        public void TestNotMultiple5or3Buzz()
        {
            string buzz = euler.GenerateFizzBuzz(7);
            Assert.AreEqual("7", buzz);
        }

        [Test]
        public void TestMultiple5and3FizzBuzz()
        {
            string fizzbuzz = euler.GenerateFizzBuzz(15);
            Assert.AreEqual("FizzBuzz", fizzbuzz);
        }

        [Test]
        public void TestMultiple5and3Sum10()
        {
            int sum = euler.GenerateSum(10);
            Assert.AreEqual(23, sum);
        }

        [Test]
        public void TestMultiple5and3Sum1000()
        {
            int sum = euler.GenerateSum(1000);
            Assert.AreEqual(233168, sum);
        }
    }
}