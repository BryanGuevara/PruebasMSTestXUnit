using System;
using Xunit;
using BAGG;

namespace ESFE.BAGG.UnitTest.AppxUnit
{
    public class StringManipulatorTest
    {

        [Fact]
        public void ReverseString()
        {
            StringManipulator text = new StringManipulator();
            string result = text.ReverseString("Hola Mundo");
            Assert.Equal("odnuM aloH", result);
        }

        [Fact]
        public void RemoveSpaces()
        {
            StringManipulator text = new StringManipulator();
            string result = text.RemoveSpaces("Hola Mundo");
            Assert.Equal("HolaMundo", result);
        }
    }
}
