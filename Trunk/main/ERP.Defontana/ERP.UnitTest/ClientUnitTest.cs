using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP.UnitTest
{

    /// <summary>
    /// Prueba fija para comprobar Test con Bamboo
    /// </summary>
    [TestClass]
    public class ClientUnitTest
    {
        [TestMethod]
        
        public void TestPruebaAssertBamboo()
        {
            string texto = "Hola Mundo";
            Assert.AreNotSame(texto.Length,0);
        }

        [TestMethod]
        public void TestPruebaErrorBamboo()
        {
            int divisor = 0;

            double valor = 5 / divisor;
            Assert.AreNotEqual(valor, 0);
        }

        [TestMethod]
        public void TestPruebaNotAssertBamboo()
        {
            int divisor = 0;

            Assert.AreNotEqual(0, divisor);
        }
    }
}
