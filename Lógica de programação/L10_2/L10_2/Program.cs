using System;
using System.Collections.Generic;

/*Considerando a necessidade de um programa que armazene o nome e as notas bimestrais de 20 alunos do curso de Técnicas de Programação,
 * defina a estrutura de registro apropriada, o diagrama de blocos e a codificação de um programa que, por meio do uso de um menu de opções, 
 * execute as seguintes etapas(Este programa deverá ser salvo com o nome L10_2):

a) Cadastrar os 20 registros. ok
b) Pesquisar os 20 registros, de cada vez, pelo campo nome.Nesta pesquisa o programa deverá também apresentar a média do aluno e as mensagens: “Aprovado” 
caso sua média seja maior ou igual a 5, ou “Reprovado” para média abaixo de 5.ok
c) Apresentar todos os registros, médias e a mensagem de aprovação ou reprovação. ok
d) Sair do programa de cadastro. ok */


namespace L10_2
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] Nome = new string[3];
            double[] N1 = new double[3];
            double[] N2 = new double[3];
            double[] N3 = new double[3];
            double[] N4 = new double[3];
            double[] N5 = new double[3];
            double[] N6 = new double[3];
            double[] Media = new double[3];
            string[] Status = new string[3];
            int Contador = 0;

            Menu();



            void Menu()
            {
                int op;
                Console.WriteLine("________________________");
                Console.WriteLine("________________________");
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine(" 1 - Cadastrar ");
                Console.WriteLine(" 2 - Pesquisar Nome ");
                Console.WriteLine(" 3 - Listar ");
                Console.WriteLine(" 4 - Sair ");
                Console.WriteLine("________________________");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Cadastrar();

                }
                else
                    if (op == 2)
                {
                    Pesquisar();
                }
                else
                    if (op == 3)
                {
                    Listar();
                }
                else
                    if (op == 4)
                {

                    Console.Beep();
                    Environment.Exit(0);
                }
                else
                    Console.WriteLine("________________________");
                Console.WriteLine("Opção Inváilda!!");
                Console.Clear();
                Menu();

            }

            void Cadastrar()
            {
                int i;

                i = Contador;

                Console.WriteLine("Cadastro - Aluno/Nota");
                Console.WriteLine("");


                Console.WriteLine("Informe o Nome : ");
                Console.WriteLine(" ");
                Nome[i] = Console.ReadLine();
                Console.WriteLine(" ");

                Console.WriteLine("Informe a nota 1 : ");
                Console.WriteLine(" ");
                N1[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("Informe a nota 2 : ");
                Console.WriteLine(" ");
                N2[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("Informe a nota 3 : ");
                Console.WriteLine(" ");
                N3[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("Informe a nota 4 : ");
                Console.WriteLine(" ");
                N4[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("Informe a nota 5 : ");
                Console.WriteLine(" ");
                N5[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("Informe a nota 6 : ");
                Console.WriteLine(" ");
                N6[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                Media[i] = ((N1[i] + N2[i] + N3[i] + N4[i] + N5[i] + N6[i]) / 6); // realiza o calculo da media

                if (Media[i] >= 5)
                {
                    Status[i] = "APROVADO! :) ";
                }
                else
                    if (Media[i] < 5)
                {
                    Status[i] = "REPROVADO!  :( ";
                }
                Console.WriteLine("Dados inseridos com sucesso!!");

                Contador = i + 1;

                Console.WriteLine("Aperte Enter : ");
                Console.ReadKey();
                Console.Clear();

            }



            void Listar()
            {
                int i = 0;

                Console.WriteLine("Alunos Listados: ");
                Console.WriteLine(" ");
                Console.WriteLine("________________________");

                while (Nome[i] != null)
                {
                    Console.WriteLine("Nome :" + Nome[i]);
                    Console.WriteLine("BIMESTRE 1 : " + N1[i]);
                    Console.WriteLine("BIMESTRE 2 : " + N2[i]);
                    Console.WriteLine("BIMESTRE 3 : " + N3[i]);
                    Console.WriteLine("BIMESTRE 4 : " + N4[i]);
                    Console.WriteLine("BIMESTRE 5 : " + N5[i]);
                    Console.WriteLine("BIMESTRE 6 : " + N6[i]);
                    Console.WriteLine("MÉDIA : " + Media[i]);
                    Console.WriteLine("Status : " + Status[i]);
                    Console.WriteLine("________________________");
                    i++;

                }
                Console.WriteLine("Aperte Enter : ");
                Console.ReadKey();
                Console.Clear();
            }

            void Pesquisar()
            {
                Console.WriteLine("Pesquisa por Nome: ");
                Console.WriteLine(" ");

                string Nomep;

                Console.WriteLine("Informe um nome : ");
                Console.WriteLine(" ");
                Nomep = Console.ReadLine();

                for (int i = 0; i <= Nome.Length; i++)
                {
                    while (Equals(Nomep, Nome[i]) == true)
                    {
                        Console.WriteLine("Nome :" + Nome[i]);
                        Console.WriteLine("BIMESTRE 1 : " + N1[i]);
                        Console.WriteLine("BIMESTRE 2 : " + N2[i]);
                        Console.WriteLine("BIMESTRE 3 : " + N3[i]);
                        Console.WriteLine("BIMESTRE 4 : " + N4[i]);
                        Console.WriteLine("BIMESTRE 5 : " + N5[i]);
                        Console.WriteLine("BIMESTRE 6 : " + N6[i]);
                        Console.WriteLine("MÉDIA : " + Media[i]);
                        Console.WriteLine("Status : " + Status[i]);
                        Console.WriteLine("________________________");
                        Console.ReadKey();
                        Console.Clear();

                        Menu();
                    }
                }
            }
        }
    }
}