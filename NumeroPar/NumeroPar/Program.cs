using System;
using System.Collections.Generic;

namespace NumeroPar
{ /*
    Desenvolva uma Aplicação console C# chamada numeropar que exiba os números de 1 a 50 na tela em ordem decrescente.
    */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numeros = new List<int>();//lista para armazenar os numeros gerados
            List<int> NumeroPar = new List<int>();//lista para armazenar numeros pares
            int Qtd =50;// contar 50 numeros a partir de 0
            Random Aleatorio = new Random();// gerar valores aleatorio
            int Num;// numero gerado



            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("Valores Aleatorios Gerados de 1 a 50 :");
            Console.WriteLine("_____________________________________________________________________________________");

            for (int i = 0; i <Qtd; i++)
            {
                Num = Aleatorio.Next(1, Qtd+1);//gera  aleatorio de 1  a 50

                while (Numeros.Contains(Num))// verifica se existe o numero gerado na lista
                {
                    if (Numeros.Count >= Qtd) //se  quantidade for maior que a quantidade sai do loop
                        break;
                    else
                        Num = Aleatorio.Next(1,Qtd+1);// caso contrario, a variavel num recebe um novo valor de 1 a 50
                }
               
                Numeros.Add(Num);
                Console.WriteLine(Numeros[i].ToString());//Imprime os numeros gerados
            }



            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("Valores Pares Gerados ordenados de forma DECRESCENTE :");
            Console.WriteLine("_____________________________________________________________________________________");

            foreach (var item in Numeros)//percorre a lista Numeros 
            {
                if(item%2==0) // verifica se o item da lista de numeros é par
                {
                    NumeroPar.Add(item);//se o numero for par salva na lista de numeros pares
                   
                }                
            }

            NumeroPar.Sort();// ordena os numeros
            NumeroPar.Reverse();// realiza a ordenação decrescente

            foreach (var item in NumeroPar) //percorre a lista de numeros pares
            {
               
                Console.WriteLine(item); // imprime os numeros pares de 1 a 50 ordenados
            }

            Console.ReadKey();
        }
    }
}
            
