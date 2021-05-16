using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;


namespace TestCalculadora
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Retorna_0_Cuando_Recibe_Vacio()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();

            //Act
            int respuesta = calculadora.Add(String.Empty);

            //Assert
            Assert.AreEqual(0, respuesta);
            /* 0 valor esperado que devuelve metodo add 
            cuando cargo string vacio */
        }

        [TestMethod]
        public void Retorna_Mismo_Numero_Recibido()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();

            //Act
            int respuesta = calculadora.Add("1");

            //Assert
            Assert.AreEqual(1, respuesta);
          
        }

        [TestMethod]
        public void Retorna_Suma_Cuando_Recibe_Dos_Numeros_Separados_Con_Coma()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();

            //Act
            int respuesta = calculadora.Add("1,2");

            //Assert
            Assert.AreEqual(3, respuesta);

        }

        [TestMethod]
        public void Retorna_Suma_Con_Cantidad_De_Numeros_Indeterminados()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();

            //Act
            int respuesta = calculadora.Add("1,2,10,5,6,7");

            //Assert
            Assert.AreEqual(31, respuesta);

        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Retorna_Excepcion_Cuando_Recibe_Letras()
        {
            Calculadora calculadora = new Calculadora();

            int respuesta = calculadora.Add("1,2,t,5,6,7");        

        }

        [TestMethod]
        public void Retorna_Suma_Cuando_Recibe_Numeros_Con_Salto_De_Linea()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();

            //Act
            int respuesta = calculadora.Add("1,2\n3");

            //Assert
            Assert.AreEqual(6, respuesta);

        }

        [TestMethod]
        public void Retorna_Suma_Con_Cualquier_Delimitador()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();

            //Act
            int respuesta = calculadora.Add("//;1;2");

            //Assert
            Assert.AreEqual(3, respuesta);

        }

        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Si_LLega_Negativo_Lanzo_Execpcion_NegativoNoPermitidoException()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();

            //Act
            int respuesta = calculadora.Add("8,-2");

        }

    }
}
