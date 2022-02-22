using System;

namespace Programacao_Estruturada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[10] { 10, 10, 0, 4, 3, 1, 10, 8, 2, 5 };
            double maior = 0, menor;
            double media = 0;
            double[] tres_maiores = new double[3];

            EncontrarMaiorValor(ref maior, ref numeros);
            Console.WriteLine("O maior valor é: " + maior);

            EncontrarMenorValor(ref numeros, out menor);
            Console.WriteLine("O menor valor é: " + menor);

            EncontrarValorMedio(ref media, ref numeros);
            Console.WriteLine("O valor médio é: " + media);

            EncontrarTresMaioresValores();
        }

        static void EncontrarMaiorValor(ref double maior_valor, ref double[] array_maior_valor)
        {
            maior_valor = -999999999;
            for (int i = 0; i < 10; i++)
            {
                if (array_maior_valor[i] > maior_valor)
                {
                    maior_valor = array_maior_valor[i];
                }
            }
        }
        static void EncontrarMenorValor(ref double[] array_menor_valor, out double menor_valor)
        {
            menor_valor = 999999999;
            for (int i = 0; i < 10; i++)
            {
                if (array_menor_valor[i] < menor_valor)
                {
                    menor_valor = array_menor_valor[i];
                }
            }
        }
        static double EncontrarValorMedio(ref double valor_medio, ref double[] array_media)
        {
            double somador = 0;
            for (int i = 0; i < 10; i++)
            {
                somador += array_media[i];
                valor_medio = somador / array_media.Length;
            }
            return valor_medio;
        }

        static void EncontrarTresMaioresValores()
        {

        }
    }
}