using System;

namespace ServicoMilitar
{
    /*
     * Desenvolva uma Aplicação console C# chamada ServicoMilitar que leia os dados de “6” pessoas (nome, sexo, idade e altura).
     * Se altura maior 1,80 e idade maior que 18, informar está apta ou não para cumprir o serviço militar obrigatório
     */
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            string Sexo;
            int Idade;
            double Altura;


            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("Cadastro Serviço Militar - Informe seus dados :");
            Console.WriteLine("_____________________________________________________________________________________");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(" INFORME O NOME : ");

                Nome = Console.ReadLine();//le nome via teclado

                Console.WriteLine("_____________________________________________________________________________________");
                Console.WriteLine(" INFORME O SEXO : ");

                Sexo = Console.ReadLine();//le do teclado

                Console.WriteLine("_____________________________________________________________________________________");
                Console.WriteLine(" INFORME A IDADE : ");

                Idade = int.Parse(Console.ReadLine());//le do teclado

                Console.WriteLine("_____________________________________________________________________________________");
                Console.WriteLine(" INFORME A ALTURA : ");

                Altura = double.Parse(Console.ReadLine());//le do teclado


                Console.WriteLine("_____________________________________________________________________________________");
                Console.WriteLine(" INFORME DE RESULTADO: ");
                Console.WriteLine("_____________________________________________________________________________________");

               
                if ((Altura>1.8)&&(Idade>18))// se altura maior que 1,8 e idade maior que 18 servir.
                    /*
                     * Condição  relativa ao que foi pedido no enunciado
                     */


              /* if ((Altura>=1.8)&&(Idade>=18))
               * 
               * CONDIÇÃO  se a altura for IGUAL OU MAIOR QUE 1.8 METROS E IDADE MAIOR QUE 18 ANOS
               */

                {
                    Console.WriteLine("_____________________________________________________________________________________");
                    Console.WriteLine("Candidato : " + Nome);
                    Console.WriteLine("Sexo : "+Sexo);
                    Console.WriteLine("Idade : " + Idade);
                    Console.WriteLine("Altura : " + Altura);
                    Console.WriteLine("_____________________________________________________________________________________");
                    Console.WriteLine(" Se encontra apto para servir !!!");
                    Console.WriteLine("_____________________________________________________________________________________");

                }
                else // caso altura menor que 1,8 e idade menor  que 18 , não está apto
                {
                    Console.WriteLine("_____________________________________________________________________________________");
                    Console.WriteLine("Candidato : " + Nome);
                    Console.WriteLine("Sexo : " + Sexo);
                    Console.WriteLine("Idade : " + Idade);
                    Console.WriteLine("Altura : " + Altura);
                    Console.WriteLine("_____________________________________________________________________________________");
                    Console.WriteLine(" Não está apto para servir !!!");
                    Console.WriteLine("_____________________________________________________________________________________");

                }
               
            }
            Console.ReadKey();
        }
    }
}
