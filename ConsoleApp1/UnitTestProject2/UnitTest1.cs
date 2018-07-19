using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Rental_test()
        {
        }

        [TestMethod]
        public void RentalByDay_rentapordia_return15()
        {
            var program = new RentalByDay();

            var result = program.Calcular(3);
            Assert.AreEqual(15, result);

        }

        [TestMethod]
        public void RentalByWeek_rentaporsemana_return120()
        {
            var program = new RentalByWeek();

            var result = program.Calcular(2);
            Assert.AreEqual(120, result);

        }
        [TestMethod]
        public void RentalByhour_rentaporhora_return120()
        {
            var program = new RentalByDay();

            var result = program.Calcular(2);
            Assert.AreEqual(120, result);

        }
    }
}
