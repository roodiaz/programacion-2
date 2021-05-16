using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio42;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Metodo_Estatico_LanzarDivideByZero_MiClase()
        {
            MiClase.LanzarDivideByZero();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Constructor_SinParam_MiClase()
        {
            MiClase clase = new MiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void Constructor_ConParam_MiClase()
        {
            MiClase clase = new MiClase(String.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void Metodo_Instancia_OtraClase()
        {
            OtraClase aux = new OtraClase();

            aux.CapturarExMiClase();
        }
    }
}
