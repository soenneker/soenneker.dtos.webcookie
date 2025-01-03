using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Dtos.WebCookie.Tests;

[Collection("Collection")]
public class WebCookieTests : FixturedUnitTest
{
    public WebCookieTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
