using System;

namespace Programacao_Estruturada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[10] { 15, -3, 0, 4, -3, 1, 13, 8, 2, -5 };
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

            EncontrarValoresNegativos(ref numeros);
            Console.WriteLine("Os valores negativos são: " + numeros);
        }
        #region Métodos

        static void EncontrarMaiorValor(ref double maior_valor, ref double[] array_numeros)
        {
            double[] array_funcao = new double[array_numeros.Length];
            array_funcao = array_numeros;
            double maior = maior_valor;
            maior = array_funcao[0];

            for (int i = 0; i < array_funcao.Length; i++)
            {
                if (array_funcao[i] > maior)
                {
                    maior = array_funcao[i];
                }
            }
            maior_valor = maior;
        }
        static void EncontrarMenorValor(ref double[] array_numeros, out double menor_valor)
        {
            double[] array_funcao = new double[array_numeros.Length];
            array_funcao = array_numeros;
            double menor = 0;
            menor_valor = array_numeros[0];

            for (int i = 0; i < array_funcao.Length; i++)
            {
                if (array_funcao[i] < menor)
                {
                    menor = array_funcao[i];
                }
            }
            menor_valor = menor;
            
        }
        static double EncontrarValorMedio(ref double valor_medio, ref double[] array_numeros)
        {
            double somador = 0;
            for (int i = 0; i < 10; i++)
            {
                somador += array_numeros[i];
                valor_medio = somador / array_numeros.Length;
            }
            return valor_medio;
        }
        static void EncontrarTresMaioresValores(ref double[] tres_maiores, ref double[] array_numeros)
        {
            for (int i = 0; i < 10; i++)
            {
                if (array_numeros[i] > tres_maiores[0])
                {
                    tres_maiores[0] = array_numeros[i];
                }
                else if (array_numeros[i] > tres_maiores[1])
                {
                    tres_maiores[1] = array_numeros[i];
                }
                else if (array_numeros[i] > tres_maiores[2])
                {
                    tres_maiores[2] = array_numeros[i];
                }
            }
        }
        static void EncontrarValoresNegativos(ref double[] array_numeros)
        {
            string str_negativos = "";
            for (int i = 0; i < 10; i++)
            {
                if (array_numeros[i] < 0)
                {
                    str_negativos = str_negativos + array_numeros[i];
                }
            }
        }


        #endregion
    }
}