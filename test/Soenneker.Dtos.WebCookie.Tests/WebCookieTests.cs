using Soenneker.Tests.HostedUnit;

namespace Soenneker.Dtos.WebCookie.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class WebCookieTests : HostedUnitTest
{
    public WebCookieTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
