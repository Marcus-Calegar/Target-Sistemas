using System;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Questao
             * 5) Escreva um programa que inverta os caracteres de um string. 
             * IMPORTANTE: 
             * a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código; 
             * b) Evite usar funções prontas, como, por exemplo, reverse;
             */
            string fraseOriginal = "SUCESSO", fraseInvertida = "";

            for (int i = 0; i < fraseOriginal.Length; i++)
            {
                fraseInvertida += fraseOriginal[fraseOriginal.Length - i - 1];
            }
            Console.WriteLine(fraseOriginal);
            Console.WriteLine(fraseInvertida);
        }
    }
}
