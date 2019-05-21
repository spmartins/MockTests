using System;
using DInjectionandMock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DInjectionandMockTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var wdependencyMock = new Mock<IDependency>();
            wdependencyMock.Setup(x => x.JoinUpper(It.IsAny<string>(), It.IsAny<string>())).Returns("A B");
            wdependencyMock.Setup(x => x.Meaning).Returns(42);

            var sut = new DependencyIsolation(wdependencyMock.Object);
            var result = sut.X();
            Assert.AreEqual("A B = 42", result);
        
        }

        [TestMethod]
        public void TestMethod2()
        {
            var wdependencyMock = new Mock<IDependency>();
            var sut = new DependencyIsolation(wdependencyMock.Object)
            {
                FirstName = "Sérgio",
                LastName = "Martins"
            };

            sut.X();
            wdependencyMock.Verify(x => x.JoinUpper("Sérgio", "Martins"), Times.Once);
            wdependencyMock.Verify(x => x.Meaning, Times.Once);

        }
    }
}
