using NUnit.Framework;
using WebNumeroLiteral.Controllers;

namespace NUnitTestNumeroLiteral
{
    public class TestNumeroLiteral
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConversionGet()
        {
            //Arange=Preparaci�n
            string num1 = "8";
            string esperado = "Ocho";

            NumeroLiteralController conv = new NumeroLiteralController();

            //Act=Ejecuci�n

            string resultado = conv.ConversionGet(num1);

            //Assert=Verificaci�n
            Assert.AreEqual(esperado, resultado);
        }
       
    }
}