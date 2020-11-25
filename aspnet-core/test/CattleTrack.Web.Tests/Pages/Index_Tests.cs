using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace CattleTrack.Pages
{
    public class Index_Tests : CattleTrackWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
