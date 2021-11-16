using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaLogica;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CapaLogica.ConexionBD.Conexion();
        }
    }
}
