using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1600_ordem_crescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string valorA, valorB, valorC, menor, medio, maior;
            menor = "";
            Console.WriteLine("Efetue a leitura de três valores (variáveis A, B e C) de qualquer tipo e apresente\n" +
                "os valores em ordem crescente.\n");
            Console.Write("Valor A: ");
            valorA = Console.ReadLine();
            Console.Write("Valor B: ");
            valorB = Console.ReadLine();
            Console.Write("Valor C: ");
            valorC = Console.ReadLine();
            Console.Write("Os valores em ordem crescente são: ");

            if (string.Compare(valorA, valorB) > 0)
            {
                if (string.Compare(valorA, valorC) > 0)
                {
                    maior = valorA;
                    if (string.Compare(valorB, valorC) > 0)
                    {
                        medio = valorB;
                        menor = valorC;
                    }
                    else
                    {
                        menor = valorB;
                        medio = valorC;
                    }
                }
                else
                {
                    medio = valorA;
                    maior = valorC;
                    menor = valorB;
                }
            }
            else
            {
                if (string.Compare(valorB, valorC) > 0)
                {
                    maior = valorB;
                    if (string.Compare(valorC, valorA) > 0)
                    {
                        medio = valorC;
                        menor = valorA;
                    }
                    else
                    {
                        medio = valorA;
                        menor = valorC;
                    }
                }
                else
                {
                    maior = valorC;
                    medio = valorB;
                    menor = valorA;
                }

            }
            Console.WriteLine(menor + ", " + medio + ", " + maior);
            Console.ReadKey();
        

        }
    }
}
