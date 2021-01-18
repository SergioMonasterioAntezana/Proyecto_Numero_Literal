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
            //Arange=Preparación
            string num1 = "8";
            string esperado = "Ocho";

            NumeroLiteralController conv = new NumeroLiteralController();

            //Act=Ejecución

            string resultado = conv.ConversionGet(num1);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);
        }
       
    }
}