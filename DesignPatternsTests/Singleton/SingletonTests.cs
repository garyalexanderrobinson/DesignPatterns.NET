using DesignPatterns.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTests.Singleton
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void AlwaysObtainTheSameActiveGovernment()
        {
            var firstGovernment = Government.Instance;
            var secondGovernment = Government.Instance;
            Assert.AreEqual(firstGovernment, secondGovernment);
        }
    }
}
