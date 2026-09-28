using Soenneker.TikTok.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.TikTok.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class TikTokOpenApiHttpClientTests : HostedUnitTest
{
    private readonly ITikTokOpenApiHttpClient _httpclient;

    public TikTokOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<ITikTokOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
