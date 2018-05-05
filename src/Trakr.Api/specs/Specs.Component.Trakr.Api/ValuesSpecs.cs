using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using Specs.Component.Trakr.Api.Helpers;

namespace Specs.Component.Trakr.Api
{
    public class ValuesSpecs
    {
        [Test]
        public void Test1()
        {
            var server = new MockHttpServer();
            var client = server.CreateClient();

            var res = client.GetStringAsync("api/values").Result;

            string[] output = JsonConvert.DeserializeObject<string[]>(res);

            output.Should().ContainInOrder(new string[] { "value1", "value2" });
        }
    }
}
