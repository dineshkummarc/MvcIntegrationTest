using MvcIntegrationTestFramework;
using Xunit;

namespace Example.Xunit
{
	public class SampleXunitTest : MvcControllerTest
	{
		public SampleXunitTest()
		{
			InitializeAspNetRuntime();

			Get("home/index");
		}

		[Fact]
		public void Should_be_successful()
		{
			Assert.Equal(200, Response.StatusCode);
		}
	}
}