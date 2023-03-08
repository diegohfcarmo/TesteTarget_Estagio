using System;

namespace InverterString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira uma palavra: ");
            string palavra = Console.ReadLine();
            string palavraInvertida = "";

            int i = palavra.Length - 1;
            while (i >= 0)
            {
                char letra = palavra[i];
                palavraInvertida += letra;
                i--;
            }

            Console.WriteLine(palavraInvertida);
        }
    }
}
