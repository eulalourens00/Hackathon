using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PomegranateTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class ObjectControlServiceTests
        {
            [TestMethod]
            public void AddObject_ShouldAddObjectToCollection()
            {
                var service = new ObjectManagmentForm();
                var testObj = new ControlObject { Id = 1, Name = "Test" };

                service.AddObject(testObj);

                var result = service.GetObject(1);
                Assert.IsNotNull(result);
                Assert.AreEqual("Test", result.Name);
            }
        }
    }
}
