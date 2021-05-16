using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaClases;
using Clases;

namespace TestCentralita
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Validar_Lista_Instanciada()
        {
            //arrange
            Centralita c = new Centralita();

            //act

            //assert
            Assert.IsNotNull(c);

        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Excepcion_Misma_Llamada_Local()
        {
            //arrange
            Centralita c = new Centralita();
            Local l1 = new Local("123",34,"321",3);
            Local l2 = new Local("123", 32, "321", 5);

            //act
            c = c + l1;
            c = c + l2;
            
            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Excepcion_Misma_Llamada_Provincial()
        {
            //arrange
            Centralita c = new Centralita();
            Provincial p1 = new Provincial("111", Provincial.Franja.Franja_1, 45, "222");
            Provincial p2 = new Provincial("111", Provincial.Franja.Franja_3, 43, "222");

            //act
            c = c + p1;
            c = c + p2;

            //assert
        }

        [TestMethod]
        public void Comparo_Mismo_Tipo_LLamada_Loc_Prov()
        {
            //arrange
            Centralita c = new Centralita();
            Provincial p1 = new Provincial("111", Provincial.Franja.Franja_1, 45, "222");
            Provincial p2 = new Provincial("111", Provincial.Franja.Franja_3, 43, "222");
            Local l1 = new Local("123", 34, "321", 3);
            Local l2 = new Local("123", 32, "321", 5);

            //act


            //assert
            Assert.AreEqual(p1, p2);
            Assert.AreEqual(l1, l2);
            Assert.AreNotEqual(p1, l1);
            Assert.AreNotEqual(p1, l2);

        }

    }
}
