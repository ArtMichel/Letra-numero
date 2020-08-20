using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numero_Letra.Controllers;

namespace UnitTestLiteral
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLit()
        {
            //Arrange
            LiteralController Target = new LiteralController();
            int numero = 4;
            string expected = "CUATRO";
            //Act
            string actual = Target.Literal_Get(numero);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
