using System;
using System.Collections.Generic;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Questao
             * 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
             * • SP – R$67.836,43 
             * • RJ – R$36.678,66 
             * • MG – R$29.229,88 
             * • ES – R$27.165,48 
             * • Outros – R$19.849,53 
             * Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.
            */
            Dictionary<string, double> faturamentoEstados = new Dictionary<string, double>()
                { { "SP", 67836.43 }, { "RJ", 36678.66 }, { "MG", 29229.88 }, { "ES", 27165.48 }, { "Outros", 19849.53 } };

            double faturamentoTotal = 0;
            foreach (var valor in faturamentoEstados.Values)
            {
                faturamentoTotal += valor;
            }

            Console.WriteLine("Percentual de representacao por estado:");
            foreach (var estado in faturamentoEstados)
            {
                double percentual = (estado.Value / faturamentoTotal) * 100;
                Console.WriteLine($"{estado.Key}: {percentual:F2}%");
            }
        }
    }
}
