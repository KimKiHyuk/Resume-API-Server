using Xunit;
using System;
using System.Net.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Net;
using APIServer;
using APIServer.Model;

namespace APIServerTests
{
    public class HttpTests
    {
        HttpClient client;
        TestServer testServer;

        public HttpTests()
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile("/home/key/repository/dotnet-project/Resume-API-Server/APIServer/appsettings.json")
            .Build();

            testServer = new TestServer(new WebHostBuilder()
            .UseConfiguration(configuration)
            .UseStartup<Startup>()
            );

            client = testServer.CreateClient();
        }

        [Theory]
        [InlineData(1)]
        public async Task TEST_GET_ABOUTME_BY_ID(int id)
        {
            HttpResponseMessage response = null;

            // Act
            response = await client.GetAsync("/resume/aboutme/" + id.ToString());

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Theory]
        [InlineData(0)]
        public async Task TEST_GET_ABOUTME_DOES_NOT_EXIST(int id)
        {
            HttpResponseMessage response = null;

            // Act
            response = await client.GetAsync("/resume/aboutme/" + id.ToString());

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }


        [Theory]
        [InlineData(new AboutMeDto("a", "b", "c", "d"))]
        public void TEST_POST_ABOUTME(AboutMeDto dto)
        {
            // assign
            var response = await client.PostAsync("/resume/aboutme/", dto);

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }


        [Theory]
        [InlineData(1)]
        public void TEST_DELETE_ABOUTME_BY_ID(int id)
        {
            // assign
            var response = await client.DeleteAsync("/resume/aboutme/" + id.ToString());

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Theory]
        [InlineData(0)]
        public void TEST_GET_ABOUTME_DOES_NOT_EXIST()
        {
            // assign
            var response = await client.DeleteAsync("/resume/aboutme/" + id.ToString());

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

    }
}