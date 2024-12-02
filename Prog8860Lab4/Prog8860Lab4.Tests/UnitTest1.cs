using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;
using Moq;

namespace Prog8860Lab4.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task TestFunction1()
        {
            // Arrange
            var logger = new Mock<ILogger>();
            var context = new DefaultHttpContext();
            var request = context.Request;

            // Act
            var result = await Prog8860Lab4.Function1.Run(request, logger.Object) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("prog8860-lab4", result.Value);
        }
    }
}