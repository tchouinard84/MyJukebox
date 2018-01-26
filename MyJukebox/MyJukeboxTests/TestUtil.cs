using Newtonsoft.Json;
using NUnit.Framework;

namespace PAGeneratorTests
{
    public static class TestUtil
    {
        public static void AssertAreEqual<T>(T actualT, T expectedT)
        {
            var actual = JsonConvert.SerializeObject(actualT);
            var expected = JsonConvert.SerializeObject(expectedT);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
