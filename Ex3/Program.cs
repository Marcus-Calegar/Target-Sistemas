using System;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Questao
             * 3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
             * • O menor valor de faturamento ocorrido em um dia do mês; 
             * • O maior valor de faturamento ocorrido em um dia do mês; 
             * • Número de dias no mês em que o valor de faturamento diário foi superior à média mensal. 
             * IMPORTANTE: 
             * a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal; 
             * b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média; 
             */
            
            string caminhoArquivo = @"..\..\exemplosJson.json";
            string arquivoJson = File.ReadAllText(caminhoArquivo);

            Faturamento[] dadosBrutos = JsonSerializer.Deserialize<Faturamento[]>(arquivoJson);
            var diasComFaturamento = dadosBrutos.Where(dado => dado.valor > 0).ToArray();

            double media = diasComFaturamento.Average(faturamento => faturamento.valor);
            double maior = diasComFaturamento.Max(faturamento => faturamento.valor);
            double menor = diasComFaturamento.Min(faturamento => faturamento.valor);
            double qtdeDiasAcimaMedia = diasComFaturamento.Count(dias => dias.valor > media);

            Console.WriteLine($"Menor faturamento do mês: {menor:C}");
            Console.WriteLine($"Maior faturamento do mês: {maior:C}");
            Console.WriteLine($"Número de dias com faturamento acima da média: {qtdeDiasAcimaMedia}");
        }
    }
}
