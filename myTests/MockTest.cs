using System;
using Xunit;
using Moq; 
using Utilities;

namespace myTests
{
    public class Mock_tests
    {
        private const int V = 3;

        [Fact]
        public void Mock_Test1()
        {
            var test = new Mock<iTest>();  


            test.Setup(x => x.Test3("hello", 3)).Returns("hello3");  
            
            Assert.Equal("hello3", test.Object.Test3("hello", 3));

            test.Verify(x =>x.Test3(It.IsAny<String>(),
                                    It.IsAny<int>()), Times.Once());

             test.Verify(x =>x.Test3("hello",
                                    3), Times.Once()); 
        }
    }
}
