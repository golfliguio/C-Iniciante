using System;

namespace NumerosImparesEntre100E200
{/*   
    Desenvolva uma Aplicação console C# chamada NumerosImparesEntre100E200 que exiba os números ímpares entre 100 e 200.
    */
    class Program
    {
        static void Main(string[] args)
        {
            int [] Numeros = new int[100]; //inicia um vetor de 100 posiçoes
            int Inicial = 100;//valor inicial 100

            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("Valores Impares de 100 a 200:");
            Console.WriteLine("_____________________________________________________________________________________");


            for (int i = 0; i <= 100; i++)// 100 valores de 100 a 200
            {
                if (Inicial%2!=0)//caso o resto da divisao do numero inicial for diferente de 0 o numero é impar
                {
                    Numeros[i] = Inicial; // salva o numero impar no vetor

                    Console.WriteLine(Numeros[i]); // escreve o numero na tela
                }            

                Inicial++;    // faz o incremento do numero inicial em uma unidade          
             }                    

            Console.ReadKey();//aguarda  comando para fechar o console
        }
    }
}
