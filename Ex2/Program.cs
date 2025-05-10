using System;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Questao
             * 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
             * escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando
             * se o número informado pertence ou não a sequência.
             * IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
             */

            int entrada = 55, anterior = 0, atual = 1, proximo = 0;
            bool encontrado = false;

            while (anterior <= entrada)
            {
                if (anterior == entrada)
                {
                    encontrado = true;
                    break;
                }

                proximo = atual + anterior;
                (anterior, atual) = (atual, proximo);
            }

            if (encontrado)
                Console.WriteLine($"Numero {entrada} pertence a sequencia de Fibonacci.");
            else
                Console.WriteLine($"Numero {entrada} NAO pertence a sequencia de Fibonacci");
        }
    }
}

