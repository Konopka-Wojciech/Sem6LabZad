using NUnit;
using TDD;

namespace NunitTest
{

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateTax_IncomeBelowFirstThreshold()
        {
            // Arrange
            TaxCalc calculator = new TaxCalc();
            decimal income = 100000m;

            // Act
            decimal tax = calculator.CalculateTax(income);

            // Assert
            Assert.AreEqual(17000m, tax);
        }

        [Test]
        public void CalculateTax_IncomeAtFirstThreshold()
        {
            // Arrange
            TaxCalc calculator = new TaxCalc();
            decimal income = 120000m;

            // Act
            decimal tax = calculator.CalculateTax(income);

            // Assert
            Assert.AreEqual(20400m, tax);
        }

        [Test]
        public void CalculateTax_IncomeAboveFirstThreshold()
        {
            // Arrange
            TaxCalc calculator = new TaxCalc();
            decimal income = 150000m;

            // Act
            decimal tax = calculator.CalculateTax(income);

            // Assert
            Assert.AreEqual(30000m, tax);
        }
    }
}