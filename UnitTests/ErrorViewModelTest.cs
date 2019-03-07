using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppCoreDemo.Models;

namespace UnitTests
{
    [TestClass]
    public class ErrorViewModelTest
    {
        [TestMethod]
        public void TestRequestId()
        {
            var model = new ErrorViewModel();
            model.RequestId = "123";
            Assert.AreEqual("123", model.RequestId);
        }
    }
}
