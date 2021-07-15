using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIniMegaSena
{
    class Program
    {
        static readonly MegaSena Jogo = new MegaSena();
        static void Main(string[] args)
        {
            string nome;
            int inciarNovamente;

            Console.WriteLine("Bem vindo ao 'Mini Mega Sena'");
            Console.Write("Digite seu Nome: ");
            nome = Console.ReadLine();
            Console.WriteLine($"Vamos jogar, {nome}?");

            do
            {
                Console.WriteLine("Escolha o nível do jogo: ");
                Console.WriteLine("Digite '1' para até 30 números");
                Console.WriteLine("Digite '2' para até 60 números");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Jogo.IniciarJogo(1);
                        break;

                    case 2:
                        Jogo.IniciarJogo(2);
                        break;

                    default:
                        Console.WriteLine("Opção inválida, pressione qualquer tecla para continuar!");
                        Console.ReadKey();
                        break;
                }

                do
                {
                    Console.WriteLine("Deseja continuar a jogar?");
                    Console.WriteLine("Digite '1' para sim");
                    Console.WriteLine("Digite '2' para não");
                    inciarNovamente = Convert.ToInt32(Console.ReadLine());

                    
                     if (inciarNovamente == 2)
                     {
                         Console.WriteLine($"Obrigado por jogar, {nome} ");
                         Console.ReadKey();
                     }
                     Console.WriteLine("Opção inválida.");
                 } while (inciarNovamente != 1 && inciarNovamente!=2);

                 Console.Clear();
                 Jogo.LimparJogo();

            } while (inciarNovamente == 1);   
        }
    }
} 
