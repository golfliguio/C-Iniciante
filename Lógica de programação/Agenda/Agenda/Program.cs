using System;
/*
 * Considerando a necessidade de desenvolver uma agenda que contenha nomes, endereços e telefones de 10 pessoas,
 * defina a estrutura de registro apropriada, o diagrama de blocos e a codificação de um programa que por meio do uso de um menu de opções, 
 * execute as seguintes etapas (Este programa deverá ser salvo com o nome L10_1):
b) Pesquisar um dos 10 registros de cada vez pelo campo nome (usar o método seqüencial).
d) Apresentar todos os registros.
e) Sair do programa de cadastro.
 */
namespace L10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nome = new string[10];
            string[] Endereco = new string[10];
            int[] Telefone = new int[10];
            int Contador = 0;


            Menu();


//Questao A
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
//Questao E
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

                Console.WriteLine("Cadastro - Agenda");
                Console.WriteLine("");


                Console.WriteLine("Informe o Nome : ");
                Console.WriteLine(" ");
                Nome[i] = Console.ReadLine();
                Console.WriteLine(" ");

                Console.WriteLine("Informe o Endereço : ");
                Console.WriteLine(" ");
                Endereco[i] = Console.ReadLine();
                Console.WriteLine(" ");

                Console.WriteLine("Informe o Telefone : ");
                Console.WriteLine(" ");
                Telefone[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");


                Console.WriteLine("Dados inseridos com sucesso!!");

                Contador = i + 1;

                Console.WriteLine("Aperte Enter : ");
                Console.ReadKey();
                Console.Clear();

            }
//Questao B
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
                    while(Equals(Nomep,Nome[i])==true)
                    {
                        Console.WriteLine("________________________");
                        Console.WriteLine("Encontrado!");
                        Console.WriteLine("Nome :" +Nome[i]);
                        Console.WriteLine("Endereço :" +Endereco[i]);
                        Console.WriteLine("Telefone :" +Telefone[i]);
                        Console.WriteLine("________________________");
                        Console.WriteLine("Aperte Enter : ");
                        Console.ReadKey();
                        Console.Clear();

                        Menu();
                    }
                   
                }
                
            }
            //função pesquisa por nome


//Questao D
            void Listar()
            {
                int i = 0;

                Console.WriteLine("Clientes Listados: ");
                Console.WriteLine(" ");
                Console.WriteLine("________________________");
               
                while(Nome[i]!=null)
                {
                    Console.WriteLine("Nome :" + Nome[i]);
                    Console.WriteLine("Endereço :" + Endereco[i]);
                    Console.WriteLine("Telefone :" + Telefone[i]);
                    Console.WriteLine("________________________");
                    i++;

                }
                Console.WriteLine("Aperte Enter : ");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
    
