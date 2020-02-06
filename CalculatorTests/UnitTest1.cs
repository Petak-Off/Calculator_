using Calculator;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetInputParamsPositiveTest()
        {
            var parser = new Parser();
            var actualResult = parser.GetInputParams("1 * 3");
            var expectedResult = new[] { "1", "*", "3" };

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]

        public void GetInputParamsNegativeTest()
        {
            var parser = new Parser();
            var actualResult = parser.GetInputParams("1* 3");
            var expectedResult = new[] { "1", "*", "3" };

            Assert.AreNotEqual(expectedResult, actualResult);

        }

        [Test]

        public void GetInputParamsPositiveTestWithTwoSpace()
        {
            var parser = new Parser();
            var actualResult = parser.GetInputParams("1  * 3");
            var expectedResult = new[] { "1", "*", "3" };

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetCalculationsPositiveTest()
        {
            var calc = new Calculation();
            var actualResult = calc.GetCalculation(new[] { "1", "+", "1" });
            var expectedResult = "2";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]

        public void GetCalculationsNegativeTest()
        {
            var calc = new Calculation();
            var actualResult = calc.GetCalculation(new[] { "1", "+", "1" });
            var expectedResult = "3";

            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetCalculationsDivisionByZeroPositiveTest()
        {
            var calc = new Calculation();
            var actualResult = calc.GetCalculation(new[] { "5", "/", "0" });
            var expectedResult = "Делить на ноль нельзя";
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetCalculationsInvalidParameterPositiveTest()
        {
            var calc = new Calculation();
            var actualResult = calc.GetCalculation(new[] { "5", "#", "0" });
            var expectedResult = "Неверные параметры";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}