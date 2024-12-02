using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using prog8860_lab4_app;
using Xunit;

namespace prog8860_lab4_app.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Run_ReturnsOkObjectResult()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<HttpExample>>();
            var httpContext = new DefaultHttpContext();
            var request = httpContext.Request;
            var httpExample = new HttpExample(loggerMock.Object);

            // Act
            var result = httpExample.Run(request);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Welcome to Azure Functions!", okResult.Value);
        }
    }
}