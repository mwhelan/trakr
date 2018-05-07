using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using Trakr.Libs.TvMaze;

namespace Specs.Smoke.Trakr.Api.Libs.TvMaze
{
    public class TvMazeSmokeTests
    {
        [Test]
        public async Task ShowSearch()
        {
            var sut = new TvMazeClient();
            var result = await sut.ShowSearch("star trek");
            result.Count.Should().Be(9);
        }

        [Test]
        public async Task GetShowBasic()
        {
            var sut = new TvMazeClient();
            var result = await sut.GetShowBasic("survivors");
            result.Name.Should().Be("Survivors");
            result.Embedded.Episodes.Count.Should().Be(0);
        }

        [Test]
        public async Task GetShowWithEpisodes()
        {
            var sut = new TvMazeClient();
            var result = await sut.GetShowWithEpisodes("survivors");
            result.Name.Should().Be("Survivors");
            result.Embedded.Episodes.Count.Should().Be(12);
        }
    }
}
