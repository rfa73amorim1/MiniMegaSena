using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIniMegaSena
{
    class MegaSena
    {
        
        public int[] NumerosEscolhidos = new int[6];
        public int[] NumerosMegaSena = new int[6];        
        int quantidadeMaxNumeros;

        public void IniciarJogo (int nivel)
        {
            quantidadeMaxNumeros = nivel * 30;

            ReceberNumeros(quantidadeMaxNumeros);
            SortearNumeros(quantidadeMaxNumeros);

            Array.Sort(NumerosEscolhidos);
            Array.Sort(NumerosMegaSena);

            Console.WriteLine("Os números escolhidos foram: ");
            for (int i = 0; i < NumerosEscolhidos.Length; i++)
            {
                Console.Write($"|{NumerosEscolhidos[i]}|");
            }
            Console.WriteLine();
            Console.WriteLine("Os números sorteados foram:");
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"|{NumerosMegaSena[i]}|");
            }

            Console.WriteLine();
            var numerosIguais = NumerosMegaSena.Intersect(NumerosEscolhidos);
            int acerto = 0;
            foreach (int item in numerosIguais)
            {
                acerto += 1;
            }

            switch (acerto)
            {
                case 4:
                    Console.WriteLine("Você acertou a quadra!");
                    break;

                case 5:
                    Console.WriteLine("Você acertou a quina!");
                    break;

                case 6:
                    Console.WriteLine("Parabéns! Você acertou na Mini Mega Sena!");
                    break;

                default:
                    Console.WriteLine("Você não Ganhou...");
                    break;
            }

        }

        public void ReceberNumeros (int quantidadeMaxNumeros)
        {
            for (int i = 0; i < NumerosEscolhidos.Length; i++)
            {
                
                bool valido = false;
                bool invalido = false;

                do
                {
                    if (invalido)
                    {
                        Console.WriteLine("Número inválido! Tente novamente");
                    }

                    Console.WriteLine($"Escolha o {i + 1}º número do seu jogo");
                    int aux = Convert.ToInt32(Console.ReadLine());
                    if (!NumerosEscolhidos.Contains(aux) && aux > 0 && aux <= quantidadeMaxNumeros)
                    {
                        NumerosEscolhidos[i] = aux;
                        valido = true;
                    }

                    else
                    {
                        invalido = true;
                    }

                } while (!valido);


            }



        }

        public void SortearNumeros (int quantidadeMaxNumeros)
        {
            Random NumeroRamdom = new Random();
            for (int i = 0; i < NumerosMegaSena.Length; i++)
            {
                bool valido = false;
                do
                {
                    int aux = NumeroRamdom.Next(1, quantidadeMaxNumeros);
                    if (!NumerosMegaSena.Contains(aux) && aux > 0 && aux <= quantidadeMaxNumeros)
                    {
                        NumerosMegaSena[i] = aux;
                        valido = true;
                    }
                } while (!valido);
            }

        }
                
        public void LimparJogo()
        {
            
            Array.Clear(NumerosEscolhidos, 0, 6);
        }
               
     }

 }

