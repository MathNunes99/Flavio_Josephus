using System;

namespace DesafiosAcad.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o numero de pessoas na roda");
            int pessoas = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o tamanho do salto");
            int salto = int.Parse(Console.ReadLine());

            string[] jogadores1 = new string[pessoas+1];
            jogadores1[0] = " ";
            for (int i = 1; i <= pessoas; i++)
            {
                jogadores1[i] = Convert.ToString(i);
            }           
            
            int contadorsaida = 0;
            int contador = 0;

            for(int i = 1; i <= jogadores1.Length; i++)
            {
                if (i > pessoas)
                {
                    i = 0;
                    continue;
                }
                if (jogadores1[i] == "0")
                {                   
                    continue;
                }
                contador = contador + 1;
                if (contador >= salto)
                {
                    jogadores1[i] = "0";
                    contador = 0;
                    contadorsaida = contadorsaida + 1;
                    if (contadorsaida == pessoas - 1)
                    {
                        break;
                    }
                }
                if (i >= pessoas)
                {
                    i = 0;
                }

            }
            for (int i = 0; i < jogadores1.Length; i++)
            {
                if (jogadores1[i] == "0")
                {
                    Console.Write("");
                }
                else
                {
                    Console.Clear();
                    Console.Write(jogadores1[i] + " É O SOBREVIVENTE!");
                }
            }
            Console.ReadLine();
        }
    }
}
