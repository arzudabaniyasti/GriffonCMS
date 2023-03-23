using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using Ecommerce.Unit.Configure;
using MediatR;
using WebApi.Controllers;
using GriffonCMS.Infrastructure.Command.Abouts;
using FluentAssertions;

namespace GriffonCMS.WebApi.UnitTest.Controllers;
public class AboutControllerTest
{
    [Theory, AutoMoqData]
    public async Task Post_About_Return_Ok_Object_Result(Mock<IMediator> mediator,CreateAboutCommand actualQuery,
        CreateAboutCommand actualCommand,Guid expected)
    {
        //Arrange

        var sut = new AboutController(mediator.Object);

        mediator.Setup(setup => setup.Send(actualQuery, default)).ReturnsAsync(expected);

        //Act

        var result = await sut.Post(actualCommand);

        //Assert

        Assert.IsType<OkObjectResult>(result);
    }

    [Theory, AutoMoqData]
    public async Task Post_About_Return_Guid(Mock<IMediator> mediator, CreateAboutCommand actualQuery,
    CreateAboutCommand actualCommand, Guid expected)
    {
        //Arrange

        var sut = new AboutController(mediator.Object);

        mediator.Setup(setup => setup.Send(actualQuery, default)).ReturnsAsync(expected);

        //Act

        var result = await sut.Post(actualCommand);

        //Assert

        var apiOkResult = result.Should().BeOfType<OkObjectResult>().Subject;
        var response =apiOkResult.Value;
        Assert.IsType<Guid>(response);
    }
}
