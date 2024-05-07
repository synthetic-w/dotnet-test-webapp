using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using BlazorApp.Shared.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Server.Tests.Controllers;

public class UserControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _httpClient;

    public UserControllerTests(WebApplicationFactory<Program> webApplicationFactory)
    {
        _httpClient = webApplicationFactory.CreateClient();
    }

    [Fact]
    public async Task Get_CommonRequest_UserDetails()
    {
        // Arrange

        string testUrl = "api/User/GetDetails";

        // Act

        var userData = await _httpClient.GetFromJsonAsync<List<UserModel>>(testUrl);

        // Assert

        Assert.NotNull(userData);
        Assert.True(userData.Any());
    }
}
