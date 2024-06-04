using NUnit.Framework;
using Moq;
using testmod;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange
            Mock<IWebService> webServiceMock = new Mock<IWebService>();
            Calculator calculator = new Calculator(webServiceMock.Object);

            // Act
            int result = calculator.Add(3, 5);

            // Assert
            Assert.AreEqual(8, result);

            // Verify that the SendData method was called with the expected argument
            webServiceMock.Verify(ws => ws.SendData("Add operation: 3 + 5 = 8"), Times.Once);
        }
    }
}