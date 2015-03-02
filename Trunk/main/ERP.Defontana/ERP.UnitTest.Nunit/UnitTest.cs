using System;
using NUnit.Framework;

namespace ERP.UnitTest.Nunit
{
    [TestFixture] // El atributo TestFixture identifica a esta clase como una clase de pruebas
    public class UnitTest
    {

        [Test] // El atributo Test identifica a este método como una prueba unitaria
        public void TestPruebaAssertBamboo()
        {
            string texto = "Hola Mundo";
            Assert.AreNotSame(texto.Length, 0);
        }

        [Test]
        public void TestPruebaErrorBamboo()
        {
            int divisor = 0;

            int valor = 1 + divisor;
            Assert.AreNotEqual(valor, 0);
        }

        [Test]
        public void TestPruebaNotAssertBamboo()
        {
            int divisor = 0;

            Assert.AreEqual(0, divisor);
        }
    }
}


