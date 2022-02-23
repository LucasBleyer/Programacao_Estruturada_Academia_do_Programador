using System;

namespace Programacao_Estruturada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] { 15, -3, 98, 3, -2, 4, 13, 8, 2, -5 };
            int maior = 0, menor, numero_remover;
            decimal media = 0;
            int[] tres_maiores_valores = new int[3];
            int[] negativos;

            Console.Write("A sequência de números é: ");
            for (int i = 0; i < numeros.Length; i++) Console.Write(numeros[i] + " ");

            EncontrarMaiorValor(ref maior, ref numeros);
            Console.WriteLine("O maior valor é: " + maior);

            EncontrarMenorValor(out menor, ref numeros);
            Console.WriteLine("O menor valor é: " + menor);

            EncontrarValorMedio(ref media, ref numeros);
            Console.WriteLine("O valor médio é: " + media);

            EncontrarTresMaioresValores(ref tres_maiores_valores, ref numeros);
            Console.WriteLine("Os três maiores valores são: " + tres_maiores_valores[0] + " " + tres_maiores_valores[1] + " " + tres_maiores_valores[2]);

            EncontrarValoresNegativos(ref numeros, out negativos);
            Console.Write("Os valores negativos são: ");
            for (int i = 0; i < negativos.Length; i++) Console.Write(negativos[i] + " ");
            
            OrdenarArray(numeros);
            Console.Write("\r\nOs valores em ordem são: ");
            for (int i = 0; i < numeros.Length; i++) Console.Write(numeros[i] + " ");

            Console.Write("\r\n\nDigite um número para remover da sequência: ");
            numero_remover = Convert.ToInt32(Console.ReadLine());
            RemoverItemSequencia(ref numero_remover,ref numeros);
            Console.Write("\r\nA nova sequência de números é: ");
            for (int i = 0; i < numeros.Length; i++) Console.Write(numeros[i] + " ");

            Console.ReadKey();
        }
        #region Métodos
        static void EncontrarMaiorValor(ref int maior_valor, ref int[] array_numeros)
        {
            int[] array_funcao = new int[array_numeros.Length];
            array_funcao = array_numeros;
            int maior = maior_valor;
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
        static void EncontrarMenorValor(out int menor_valor, ref int[] array_numeros)
        {
            int[] array_funcao = new int[array_numeros.Length];
            array_funcao = array_numeros;
            int menor = 0;
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
        static decimal EncontrarValorMedio(ref decimal valor_medio, ref int[] array_numeros)
        {
            decimal somador = 0;
            for (int i = 0; i < array_numeros.Length; i++)
            {
                somador += array_numeros[i];
                valor_medio = somador / array_numeros.Length;
            }
            return valor_medio;
        }
        static void EncontrarTresMaioresValores(ref int[] tres_maiores, ref int[] array_numeros)
        {
            for (int i = 0; i < array_numeros.Length; i++)
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
        static void EncontrarValoresNegativos(ref int[] array_numeros, out int[] array_negativos)
        {
            int cont_negativos = 0;
            for (int i = 0; i < array_numeros.Length; i++)
            {
                if (array_numeros[i] < 0)
                {
                    cont_negativos++;
                }
            }
            int[] array_numeros_negativos = new int[cont_negativos];
            cont_negativos = 0;
            for (int i = 0; i < array_numeros.Length; i++)
            {
                if (array_numeros[i] < 0)
                {
                    array_numeros_negativos[cont_negativos] = array_numeros[i];
                    cont_negativos++;
                }
            }
            array_negativos = array_numeros_negativos;
        }
        static void OrdenarArray(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < (numeros.Length - 1); j++)
                {
                    int troca;
                    if (numeros[j] > numeros[j + 1])
                    {
                        troca = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = troca;
                    }
                }
            }
        }
        static void RemoverItemSequencia(ref int numero_remover, ref int[] array_numeros)
        {
            int cont_remover = 0;
            for (int i = 0; i < array_numeros.Length; i++)
            {
                if (array_numeros[i] == numero_remover)
                {
                    cont_remover++;
                }
            }

            int[] novo_array_numeros = new int[array_numeros.Length - cont_remover];
            int j = 0;
            for (int i = 0; i < array_numeros.Length; i++)
            {
                if (array_numeros[i] != numero_remover)
                {
                    novo_array_numeros[j] = array_numeros[i];
                    j++;
                }
            }
            array_numeros = novo_array_numeros;
        }
        #endregion
    }
}