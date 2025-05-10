using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Questao
             * 1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
             * Enquanto K < INDICE faça 
             * { 
             *      K = K + 1; 
             *      SOMA = SOMA + K; 
             * } 
             * Imprimir(SOMA); 
             * Ao final do processamento, qual será o valor da variável SOMA?
             * O Resultado final sera 91
             */
            int soma = 0, indice = 13, k = 0;

            while (k < indice)
            {
                k += 1;
                soma += k;
            }
            Console.WriteLine(soma);
        }
    }
}
