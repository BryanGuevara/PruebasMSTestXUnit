using Microsoft.VisualStudio.TestTools.UnitTesting;
using BAGG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAGG.Tests
{
    [TestClass()]
    public class TemperatureConverterTests
    {
        [TestMethod()]
        public void CelsiusToFahrentheitTest()
        {
            TemperatureConverter converter = new TemperatureConverter();
            double result = converter.CelsiusToFahrentheit(25);
            Assert.AreEqual(77, result);
        }

        [TestMethod()]
        public void FahrentheitToCelsiusTest()
        {
            TemperatureConverter converter = new TemperatureConverter();
            double result = converter.FahrentheitToCelsius(77);
            Assert.AreEqual(25, result);
        }
    }
}