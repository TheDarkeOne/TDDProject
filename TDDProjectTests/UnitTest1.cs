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
            string buzz = euler.GenerateFizzBuzz(5);
            Assert.AreEqual("Buzz", buzz);
        }

        [Test]
        public void TestMultiple5and3FizzBuzz()
        {
            EulerProblem1 euler = new EulerProblem1();
            string fizzbuzz = euler.GenerateFizzBuzz(15);
            Assert.AreEqual("FizzBuzz", fizzbuzz);
        }

        [Test]
        public void TestMultiple5and3Sum10()
        {
            EulerProblem1 euler = new EulerProblem1();
            int sum = euler.GenerateSum(10);
            Assert.AreEqual(23, sum);
        }

        [Test]
        public void TestMultiple5and3Sum1000()
        {
            EulerProblem1 euler = new EulerProblem1();
            int sum = euler.GenerateSum(1000);
            Assert.AreEqual(233168, sum);
        }
    }
}