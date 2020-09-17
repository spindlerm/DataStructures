using System;
using System.IO;
using Xunit;
using Utilities;
using System.Text;

namespace myTests
{
    public class TestUnitTestSDOUT
    {
        [Fact]
        public void GivenString_WhenWrittenToStOut_ThenValidateStringWrittenToSTDOUT()
        {
            string s= "this is the string to write to STDOUT";
            StringBuilder builder = new StringBuilder();
            TextWriter writer = new StringWriter(builder);
            Console.SetOut(writer);

            Console.WriteLine(s);

            Assert.Equal(s + "\r\n", builder.ToString());
        }
    }
}