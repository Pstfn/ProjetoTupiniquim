using System;

namespace Robô.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do Grid");
            Console.WriteLine("Digite o valor de X: ");
            int gridX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y: ");
            int gridY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Clear();

            int[] ValorX = new int[2];
            int[] ValorY = new int[2];
            string[] posicao = new string[2];
            string[] controleRobo = new string[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite a posição do robô");
                Console.Write("Digite o valor X: ");
                ValorX[i] = Convert.ToInt32(Console.ReadLine());
                while (ValorX[i] > gridX || ValorX[i] < 0)
                {
                    Console.WriteLine("Posição não pertence ao grid, digite um número válido.");
                    Console.Write("Digite o valor X: ");
                    ValorX[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Digite o valor Y: ");
                ValorY[i] = Convert.ToInt32(Console.ReadLine());
                while (ValorY[i] > gridY || ValorY[i] < 0)
                {
                    Console.WriteLine("Posição não pertence ao grid, digite um número válido.");
                    Console.Write("Digite o valor Y: ");
                    ValorY[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Digite a direção que o robo esta olhando utilizando somente letras maiúsculas. \nSendo Norte (N), Sul (S), Leste (L), e Oeste (O): ");
                posicao[i] = Console.ReadLine();
                while (posicao[i] != "N" && posicao[i] != "S" && posicao[i] != "O" && posicao[i] != "L")
                {
                    Console.WriteLine("Direção inválida!");
                    Console.Write("Em qual direção o robo esta olhando. Norte (N), Sul (S), Leste (L), e Oeste (O): ");
                    posicao[i] = Console.ReadLine();
                }

                Console.Write("Mova o robô com os seguintes comandos: \nPara virar a esquerda digite: E. \nPara virar a direita digite: D. \nPara mover-se para frente digite: M.");
                Console.WriteLine();
                controleRobo[i] = Console.ReadLine();
                Console.Clear();
            }

            char[] controleRoboUm = controleRobo[0].ToCharArray();
            char[] controleRoboDois = controleRobo[1].ToCharArray();

            for (int i = 0; i < controleRoboUm.Length; i++)
            {   
                if (controleRoboUm[i] == 'E')
                {
                    if (posicao[0] == "N")
                    {
                        posicao[0] = "O";
                    }
                    else if (posicao[0] == "O")
                    {
                        posicao[0] = "S";
                    }
                    else if (posicao[0] == "S")
                    {
                        posicao[0] = "L";
                    }
                    else if (posicao[0] == "L")
                    {
                        posicao[0] = "N";
                    }
                }
                if (controleRoboUm[i] == 'D')
                {
                    if (posicao[0] == "N")
                    {
                        posicao[0] = "L";
                    }
                    else if (posicao[0] == "L")
                    {
                        posicao[0] = "S";
                    }
                    else if (posicao[0] == "S")
                    {
                        posicao[0] = "O";
                    }
                    else if (posicao[0] == "O")
                    {
                        posicao[0] = "N";
                    }
                }
                if (controleRoboUm[i] == 'M')
                {
                    if (posicao[0] == "N")
                    {
                        ValorY[0]++;
                    }
                    else if (posicao[0] == "L")
                    {
                        ValorX[0]++;
                    }
                    else if (posicao[0] == "S")
                    {
                        ValorY[0]--;
                    }
                    else if (posicao[0] == "O")
                    {
                        ValorX[0]--;
                    }
                }
            }

            for (int i = 0; i < controleRoboDois.Length; i++)
            {
                if (controleRoboDois[i] == 'E')
                {
                    if (posicao[1] == "N")
                    {
                        posicao[1] = "O";
                    }
                    else if (posicao[1] == "O")
                    {
                        posicao[1] = "S";
                    }
                    else if (posicao[1] == "S")
                    {
                        posicao[1] = "L";
                    }
                    else if (posicao[1] == "L")
                    {
                        posicao[1] = "N";
                    }
                }
                if (controleRoboDois[i] == 'D')
                {
                    if (posicao[1] == "N")
                    {
                        posicao[1] = "L";
                    }
                    else if (posicao[1] == "L")
                    {
                        posicao[1] = "S";
                    }
                    else if (posicao[1] == "S")
                    {
                        posicao[1] = "O";
                    }
                    else if (posicao[1] == "O")
                    {
                        posicao[1] = "N";
                    }
                }
                if (controleRoboDois[i] == 'M')
                {
                    if (posicao[1] == "N")
                    {
                        ValorY[1]++;
                    }
                    else if (posicao[1] == "L")
                    {
                        ValorX[1]++;
                    }
                    else if (posicao[1] == "S")
                    {
                        ValorY[1]--;
                    }
                    else if (posicao[1] == "O")
                    {
                        ValorX[1]--;
                    }
                }
            }

            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("o resultado é: " + ValorX[i] + " " + ValorY[i] + " " + posicao[i]);
            }     
        }
    }
}

