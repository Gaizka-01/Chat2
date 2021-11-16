using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaLogica;
namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void PruebaUsuarioAlumno()
        {
            int CI = 1;
            bool resultado = CapaLogica.ConexionBD.DevolverAlumno(CI);
            Assert.AreEqual(false, resultado);

        }

        [TestMethod]
        public void PruebaBajaUsuario()
        {
            int CIu = 1;
            bool resultado = CapaLogica.ConexionBD.BajaUsuario(CIu);
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void PruebaDevolverProfesor()
        {
            int CIu = 2;
            bool resultado = CapaLogica.ConexionBD.devolverProfesor(CIu);
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void PruebaDevolverPersona()
        {
            string usu = "jorge";
            bool resultado = CapaLogica.ConexionBD.devolverPersona(usu);
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void PruebaBuscarUsuario()
        {
            string usu = "jorge";
            int ci = 1234;
            string contra = "123";
            string condi = "Docente";
            bool resultado = CapaLogica.ConexionBD.BuscarUsuario(usu, ci, contra, condi);
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void PruebaMostrarAgenda()
        {
            bool resultado = CapaLogica.ConexionBD.MostrarAgenda();
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void PurebaMostraCambiarDatosA()
        {
            string grupo = "3BA"; 
            bool resultado = CapaLogica.ConexionBD.MostrarCambiarDatosA(grupo);
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void PruebaDocentes()
        {
            bool resultado = CapaLogica.ConexionBD.Docentes();
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void PruebaDevolverGrupo()
        {
            string grupo = "3BA";
            bool resultado = CapaLogica.ConexionBD.DevolverGrupo(grupo);
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void PruebaConexion()
        {
            bool resultado = CapaLogica.ConexionBD.Conexion();
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void PruebaCerrarConexion()
        {
            bool resultado = CapaLogica.ConexionBD.CerrarConexion();
            Assert.AreEqual(false, resultado);
        }
    }


    
}
