using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TechnicalChallengeLocaliza;

namespace testes
{
    [TestClass]
    public class TechnicalChallengeLocalizaTestes
    {
        [TestMethod]
        public void TesteRetornaPrimos()
        {
            List<int> listaDeInteiros = new List<int>(){0,1,2,3,4,5,6,7,8,9,10};
            List<int> listaDePrimosQueDeveRetornar = new List<int>() { 1, 2, 3, 5, 7 };
            Calculadora calculadora = new Calculadora();
            var retorno = calculadora.retornaPrimos(listaDeInteiros);
            CollectionAssert.AreEqual(retorno, listaDePrimosQueDeveRetornar);
        }

        [TestMethod]
        public void TesteRetornaDivisores()
        {
            List<int> listaDeInteiros = new List<int>() { 1,3,5,9,15,45};
            Calculadora calculadora = new Calculadora();
            List<int> retorno = new List<int>();
            retorno = calculadora.retornaDivisoresNumero(45);
            CollectionAssert.AreEqual(retorno, listaDeInteiros);
        }

        [TestMethod]
        public void TesteRetornaPrimosFalha()
        {
            List<int> listaDeInteiros = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> listaDePrimosQueDeveRetornar = new List<int>() { 2, 3, 5, 7 };
            Calculadora calculadora = new Calculadora();
            var retorno = calculadora.retornaPrimos(listaDeInteiros);
            Assert.AreNotEqual(listaDePrimosQueDeveRetornar, listaDeInteiros);
        }

        [TestMethod]
        public void TesteRetornaDivisoresFalha()
        {
            List<int> listaDeInteiros = new List<int>() { 1, 3, 5, 9, 15, 45 };
            Calculadora calculadora = new Calculadora();
            var retorno = calculadora.retornaDivisoresNumero(45);
            Assert.AreNotEqual(retorno, listaDeInteiros);
        }

        [TestMethod]
        public void TesteImprimeSaida()
        {
            var texto = "Divisores Primos:";
            List<int> listaDeInteiros = new List<int>() { 1, 3, 5, 9, 15, 45 };
            Calculadora calculadora = new Calculadora();
            calculadora.imprimeArraySaida(listaDeInteiros, texto);
        }
    }
}
