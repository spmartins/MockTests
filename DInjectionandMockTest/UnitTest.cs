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
        public void TestMethod()
        {
            var writerMock = new Mock<IMessageWriter>();

            var sut = new Salutation(writerMock.Object);
            sut.Exclaim();
            writerMock.Verify(w => w.Write("Hello DI!"));
        
        }
    }
}
