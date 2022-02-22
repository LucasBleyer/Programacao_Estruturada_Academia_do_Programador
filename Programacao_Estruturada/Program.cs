using System;

namespace Programacao_Estruturada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[10] { 15, 14, 0, 4, 3, 1, 13, 8, 2, 5 };
            double maior = 0, menor;
            double media = 0;
            double[] tres_maiores_valores = new double[3];

            EncontrarMaiorValor(ref maior, ref numeros);
            Console.WriteLine("O maior valor é: " + maior);

            EncontrarMenorValor(ref numeros, out menor);
            Console.WriteLine("O menor valor é: " + menor);

            EncontrarValorMedio(ref media, ref numeros);
            Console.WriteLine("O valor médio é: " + media);

            EncontrarTresMaioresValores(ref tres_maiores_valores, ref numeros);
            Console.WriteLine("Os três maiores valores são: " + tres_maiores_valores[0] + ", " + tres_maiores_valores[1] + ", " + tres_maiores_valores[2]);
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

        static void EncontrarTresMaioresValores(ref double[] tres_maiores, ref double[] array_tres_maiores)
        {
            for (int i = 0; i < 10; i++)
            {
                if (array_tres_maiores[i] > tres_maiores[0])
                {
                    tres_maiores[0] = array_tres_maiores[i];
                }
                else if (array_tres_maiores[i] > tres_maiores[1])
                {
                    tres_maiores[1] = array_tres_maiores[i];
                }
                else if (array_tres_maiores[i] > tres_maiores[2])
                {
                    tres_maiores[2] = array_tres_maiores[i];
                }
            }
        }
    }
}