using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NSubstitute;
using RichardSzalay.MockHttp;
using Trakr.Api;

namespace Specs.Component.Trakr.Api.Helpers
{
    public class MockHttpServer
    {
        private readonly TestServer _testServer;

        public MockHttpServer(params MockedEndpoint[] mockedEndpoints)
        {
            //var loggerFactory = Substitute.For<ILoggerFactory>();
            //var startup = new Startup(loggerFactory);

            //var hostingEnvironment = Substitute.For<IHostingEnvironment>();
            //hostingEnvironment.EnvironmentName.Returns("Development");

            //var lifetime = Substitute.For<IApplicationLifetime>();

            var webHostBuilder = new WebHostBuilder()
                .UseUrls("http://*:6050")
                .UseStartup<Startup>()
                //.Configure(app => startup.Configure(app, hostingEnvironment))
                //.ConfigureServices(startup.ConfigureServices)
                .ConfigureServices(services =>
                {
                    //Add other mocks here like sqs client :) 
                    services.AddTransient(_ => TestContextHttpClient.Get(mockedEndpoints));
                });

            _testServer = new TestServer(webHostBuilder);
        }

        public HttpClient CreateClient() => _testServer.CreateClient();
    }


    public class MockedEndpoint
    {
        public MockedEndpoint(string uri, HttpStatusCode httpStatusCode, string responseBody)
        {
            Uri = uri;
            HttpStatusCode = httpStatusCode;
            ResponseBody = responseBody;
        }

        public string Uri { get; }

        public HttpStatusCode HttpStatusCode { get; }

        public string ResponseBody { get; }
    }

    public static class TestContextHttpClient
    {
        private const string ContentType = "application/json";

        public static HttpClient Get(params MockedEndpoint[] mockedEndpoints)
        {
            var mockHttp = new MockHttpMessageHandler();

            foreach (var endpoint in mockedEndpoints)
            {
                mockHttp.When(endpoint.Uri).Respond(endpoint.HttpStatusCode, ContentType, endpoint.ResponseBody);
            }

            return mockHttp.ToHttpClient();
        }
    }
}
