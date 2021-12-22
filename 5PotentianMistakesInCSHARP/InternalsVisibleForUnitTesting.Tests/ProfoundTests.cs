using Xunit;

namespace InternalsVisibleForUnitTesting.Tests
{
    public class ProfoundTests
    {
        [Fact]
        public void IsThingExpensive_Should_BeTrue()
        {
            var testClass = new ClassToTest();
            // ...
        }
    }
}
