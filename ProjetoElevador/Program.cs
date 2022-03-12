using System;
using ProjetoElevador.Models;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();

            Console.WriteLine("Digite a quantidade de andares");
            string totalAndares = Console.ReadLine();

            Console.WriteLine("Digite a capacidade do elevador");
            string capacidadeElevador = Console.ReadLine();


            int numero = 0;
            Console.WriteLine("-------------------------------------Digite para Começar------------------------");
            do
            {
                Console.WriteLine(@"                                    1 - Digite para Entrar
                                    2 - Digite para Sair
                                    3 - Digite para Subir
                                    4 - Digite para Descer
                                    5 - Digite para Sair Do Programa");
                string OpecaoEscolhida = Console.ReadLine();
                numero = Convert.ToInt32(OpecaoEscolhida);
                elevador.Inicializar(Convert.ToInt32(capacidadeElevador), Convert.ToInt32(totalAndares));

                Console.WriteLine("-------------------------------------------------");
                string PergNovamente;

                switch (numero)
                {


                    case 1:
                        PergNovamente = elevador.Entrar();
                        Console.WriteLine(PergNovamente);
                        break;

                    case 2:
                        PergNovamente = elevador.Sair();
                        Console.WriteLine(PergNovamente);
                        break;

                    case 3:
                        PergNovamente = elevador.Subir();
                        Console.WriteLine(PergNovamente);
                        break;

                    case 4:
                        PergNovamente = elevador.Descer();
                        Console.WriteLine(PergNovamente);
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Numero incorreto");
                        break;
                }

            } while (numero != 6);

        }
    }
}
