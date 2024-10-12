using CrownShop.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace CrownShop.Tests.Controllers;

public class HomeControllerTests
{
    [Fact]
    public void Index_ReturnsAViewResult()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<HomeController>>();
        var controller = new HomeController(mockLogger.Object);

        // Act
        var result = controller.Index();

        // Assert
        Assert.IsType<ViewResult>(result);
    }
}