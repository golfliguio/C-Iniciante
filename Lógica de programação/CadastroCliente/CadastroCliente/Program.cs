using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

/*
 * crie o seguinte projeto:
1 - Criar um cadastro de clientes (nome, CPF e celular)
2 - Procurar clientes pelo CPF
3 - Listar todos os clientes

 */
namespace CadastroCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ClienteNome = new string[4];//cadastro para 4 cliente, para aumentar deve modificar o tamanho do vetor
            int[] CPF = new int[4];
            int[] Celular = new int[4];
            int Contador=0;

            

            Menu();
            //Inicializa o metodo Menu



            void Cadastra()
            {
                int i;

                i = Contador;

                Console.WriteLine("Cadastro de Clientes");
                Console.WriteLine("");

               
                    Console.WriteLine("Informe o Nome do cliente : ");
                    Console.WriteLine(" ");
                    ClienteNome[i] = Console.ReadLine();
                    Console.WriteLine(" ");

                    Console.WriteLine("Informe o CPF do cliente : ");
                    Console.WriteLine(" ");
                    CPF[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");

                    Console.WriteLine("Informe o Celular do cliente : ");
                    Console.WriteLine(" ");
                    Celular[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");


                    Console.WriteLine("Dados inseridos com sucesso!!");

                    Contador = i+1;

                     Console.WriteLine("Aperte Enter : ");
                     Console.ReadKey();
                    Console.Clear();

                }
            
            //função de cadastro de cliente

            void Pesquisa()
            {
                Console.WriteLine("Pesquisa por CPF: ");
                Console.WriteLine(" ");

                int cpf;

                Console.WriteLine("Informe o CPF do cliente : ");
                Console.WriteLine(" ");
                cpf = int.Parse(Console.ReadLine());

                for (int i = 0; i <=ClienteNome.Length; i++)
                {
                    while (cpf == CPF[i])
                    {
                        Console.WriteLine("Cliente encontrado!");
                        Console.WriteLine(ClienteNome[i]);
                        Console.WriteLine(CPF[i]);
                        Console.WriteLine(Celular[i]);

                        Console.WriteLine("Aperte Enter : ");
                        Console.ReadKey();
                    }
                }
            }
            //função pesquisa por CPF

            void Lista()
            {
                int i = 0;

                Console.WriteLine("Clientes Listados: ");

                while(ClienteNome[i]!=null)
                {
                    Console.WriteLine("________________________");
                    Console.WriteLine("Cliente " +( i + 1));
                    Console.WriteLine("Nome do cliente : ");
                    Console.WriteLine(ClienteNome[i]);
                    Console.WriteLine("CPF do cliente : ");
                    Console.WriteLine(CPF[i]);
                    Console.WriteLine("Celular do cliente : ");
                    Console.WriteLine(Celular[i]);
                    Console.WriteLine(" ");
                    Console.WriteLine("________________________");
                    

                    i++;
                }

                Console.WriteLine("Aperte Enter : ");
                Console.ReadKey();

            }



            void Menu()
            {
                int op;
                Console.WriteLine("________________________");
                Console.WriteLine("________________________");
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine(" 1 - Cadastrar");
                Console.WriteLine(" 2 - Pesquisar CPF");
                Console.WriteLine(" 3 - Listar ");
                Console.WriteLine("________________________");

                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Cadastra();
                }
                else
                    if (op == 2)
                {
                    Pesquisa();
                }
                else
                    if (op == 3)
                    Lista();
                else
                Console.WriteLine("________________________");
                Console.WriteLine("Opção Inváilda!!");
                Console.Clear();
                Menu();



            }




        }

    }
}


    

