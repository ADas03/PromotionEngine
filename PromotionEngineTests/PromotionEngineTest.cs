using NUnit.Framework;
using PromotionEngine;
using PromotionEngine.BusinessLogic;
using Moq;

namespace PromotionEngineTests
{
    public class PromotionEngineTest
    {
        private Engine m_engine;
        private Mock<IProvider> m_provider;
        private Mock<IConsole> m_console;
        [SetUp]
        public void Setup()
        {
            m_provider = new Mock<IProvider>();
            m_console = new Mock<IConsole>();
            m_engine = new Engine(m_provider.Object, m_console.Object);
        }

        [Test]
        public void EngineClassTest()
        {
            // Mocking the methods
            m_console.Setup(s => s.ReadLine()).Returns("2");
            m_provider.Setup(s => s.GetTotalPrice(2, 2, 2, 2)).Returns(205);
            m_engine.MainApplication();
            Assert.Pass();
        }

    }
}