using System;
using System.Collections.Generic;

namespace TechnicalChallengeLocaliza
{
    public class Calculadora
    {
        public void CalculadoraMain()
        {
            try
            {
                Console.Write("Digite um número: ");
                var entrada = Console.ReadLine();
                List<int> divisores = new List<int>();
                divisores = retornaDivisoresNumero(int.Parse(entrada));
                Console.WriteLine("Número de Entrada: " + entrada);
                imprimeArraySaida(divisores, "Número de divisores:");
                List<int> primos = new List<int>();
                primos = retornaPrimos(divisores);
                imprimeArraySaida(primos, "Divisores Primos:");
            }catch(Exception e)
            {
                Console.WriteLine("Caractere de entrada inválido");
            }
        }

        public void imprimeArraySaida(List<int> arrayImprimir, string texto)
        {
            Console.Write(texto);
            for(var i = 0; i < arrayImprimir.Count; i++)
            {
                Console.Write(" " + arrayImprimir[i]);
            }
            Console.WriteLine();
        }

        public List<int> retornaDivisoresNumero(int entrada)
        {
            List<int> retorno = new List<int>();
            retorno.Add(1);
            for (int i=2;i<= entrada; i++)
            {
                if (entrada % i == 0)
                {
                    retorno.Add(i);
                }
            }
            return retorno;
        }

       public List<int> retornaPrimos(List<int> divisores)
        {
           List<int> primos = new List<int>();
           primos.Add(1);
           for(int i = 0; i < divisores.Count; i++)
            {
                if ((retornaDivisoresNumero(divisores[i])).Count == 2)
                {
                    primos.Add(divisores[i]);
                }
            }
            return primos;
        }
    }
}
