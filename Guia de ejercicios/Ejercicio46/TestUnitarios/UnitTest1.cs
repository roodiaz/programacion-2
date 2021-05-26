using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio46;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Verifica_Lista_Competidores_Instanciada()
        {
            Competencia c = new Competencia(5,10,Competencia.TipoCompetencia.MotoCross);

            Assert.IsNotNull(c);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Excepcion_Vehiculo_Incorrecto()
        {
            Competencia c = new Competencia(5, 10, Competencia.TipoCompetencia.MotoCross);
            AutoF1 a = new AutoF1(1, "Ferrari", 500);

            bool b = c + a;
        
        }

        [TestMethod]
        public void Excepcion_Vehiculo_Correcto()
        {
            Competencia c = new Competencia(5, 10, Competencia.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(1, "Honda", 160);

            bool b = c + m;

            Assert.IsTrue(b);

        }

        [TestMethod]
        public void Agregar_Vehiculo_Existente()
        {
            //arrage
            Competencia c = new Competencia(8, 10, Competencia.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(1, "Honda", 160);
            MotoCross m2 = new MotoCross(1, "Honda", 160);

            //Act
            bool iguales = m == m2;
            bool agrego = c + m;
            bool agregoRepetido = c + m2;

            //Assert
            CollectionAssert.Contains(c.Competidores, m);
            Assert.IsTrue(iguales);

        }

        [TestMethod]
        public void Eliminar_Vehiculo_Existente()
        {
            //arrage
            Competencia c = new Competencia(8, 10, Competencia.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(1, "Honda", 160);

            //Act
            bool agrego = c + m;
            bool elimino = c - m;

            //Assert
            Assert.IsTrue(c != m);

        }
    }
}
