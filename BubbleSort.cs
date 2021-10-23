using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados
{
    class BubbleSort
    {

        private static int[] vetor = {5, 9, 1, 2, 6, 0, 4, 3, 8, 7};
        static void Main(string[] args)
        {

            int aux;
            int tamanho = vetor.Length;

            Console.WriteLine("Vetor desordenado:");
            Console.WriteLine("[{0}]", string.Join(", ", vetor));
            Console.WriteLine("------------------------------");

            for(int i = 0; i < tamanho; i++) {

                for(int j=0; j < tamanho - 1 - i; j++){

                    if(vetor[j] > vetor[j+1]){

                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;

                    }

                }

            }

            Console.WriteLine("Vetor ordenado:");
            Console.WriteLine("[{0}]", string.Join(", ", vetor));

        }

    }

}
