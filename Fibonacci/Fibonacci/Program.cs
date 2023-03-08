using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
            //escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
            //IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

            int primeiroDigito = 0;
            int segundoDigito = 1;
            int ultimoDigito = 0;

            Console.Write("Informe o número deseja verificar: ");
            int nInformado = int.Parse(Console.ReadLine());

            if (nInformado == 0 || nInformado == 1)
            {
                Console.WriteLine();
                Console.WriteLine($"O número informado ({nInformado}) pertence à sequência de Fibonacci!");
            }
            else
            {
                while (ultimoDigito < nInformado)
                {
                    ultimoDigito = primeiroDigito + segundoDigito;
                    primeiroDigito = segundoDigito;
                    segundoDigito = ultimoDigito;
                }
                if (ultimoDigito == nInformado)
                {
                    Console.WriteLine();
                    Console.WriteLine($"O número informado ({nInformado}) pertence à sequência de Fibonacci!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"O número informado ({nInformado}) NÃO pertence à sequência de Fibonacci!");
                }
            }
        }
    }
}

