using System;

namespace pjogoVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[,] velha = new char[3, 3];
            int posição;
            char jogador ;
            bool verificador = false;
            int cont;

           

            Iniciar();
            //Console.ReadKey();
           

            void Iniciar()
            {

                for (int coluna = 0; coluna < 3; coluna++)
                {
                    velha[0, coluna] = ' ';
                    velha[1, coluna] = ' ';
                    velha[2, coluna] = ' ';
                }

                posição = 0;
                jogador = 'x';
                cont = 0;
                verificador = false;
                Tabuleiro();
            }

            for (cont = 0; cont < 9  ;)
            {

                do
                {

                    Console.WriteLine("\n Jogador X digite a sua posição");
                    posição = int.Parse(Console.ReadLine());
                    jogador = 'X';

                    Posicao();
                    Tabuleiro();
                    if (cont > 5)
                    {
                        VerHorizontal(velha);
                        VerVertical(velha);
                        VerDiagonal(velha);
                    }

                } while (verificador == true);

                do
                {

                    Console.WriteLine("\n Jogador O digite a sua posição");
                    posição = int.Parse(Console.ReadLine());    
                    jogador = 'O';

                    Posicao();
                    Tabuleiro();

                    if (cont > 5)
                    {
                        VerHorizontal(velha);
                        VerVertical(velha);
                        VerDiagonal(velha);
                        Veia();
                    }


                }while (verificador == true);
            }

            
            void Posicao()
            {
                
                //if(velha)
                switch (posição)
                {

                    case 1:
                        if (velha[2, 0] != ' ')
                        {
                            verificador = true;
                        }
                        else
                        {
                            velha[2, 0] = jogador;
                            verificador = false;
                            cont++;
                        }
                        break;

                    case 2:
                       
                        if (velha[2, 1] != ' ')
                        {
                            verificador = true;
                        }
                        else { 
                            velha[2, 1] = jogador;
                            verificador = false;
                            cont++;
                        }
                        break;

                    case 3:
                        if (velha[2, 2] != ' ')
                        {
                            verificador = true;
                            
                        }
                        else
                        {
                            velha[2, 2] = jogador;
                            verificador = false;
                            cont++;
                        } break;

                    case 4:
                        if (velha[1, 0] != ' ')
                        {
                            verificador = true;
                        }
                        else { velha[1, 0] = jogador;
                             verificador = false;
                              cont++;
                        } break;

                    case 5:
                        if(velha[1, 1] != ' ')
                        {
                            verificador = true;

                        }
                        else
                        {
                            velha[1, 1] = jogador;
                            verificador = false;
                            cont++;
                        }
                        break;

                    case 6:
                        if (velha[1, 2] != ' ')
                        {
                            verificador = true;
                        }
                        else
                        {
                            velha[1, 2] = jogador;
                            verificador = false;
                            cont++;
                        }
                        break;

                    case 7:
                        if (velha[0, 0] != ' ')
                        {
                            verificador = true;
                        }
                        else
                        {
                            velha[0, 0] = jogador;
                            verificador = false;
                            cont++;
                        }
                        break;

                    case 8:
                        if (velha[0, 1] != ' ')
                        {
                            verificador = true;
                        }
                        else
                        {
                            velha[0, 1] = jogador;
                            verificador = false;
                            cont++;
                        }
                        break;

                    case 9:
                        if (velha[0, 2] != ' ')
                        {
                            verificador = true;
                        }
                        else
                        {
                            velha[0, 2] = jogador;
                            verificador = false;
                            cont++;
                        }
                        break;
                }
            }


            void VerHorizontal(char[,] velha)
            {


                if (velha[0, 0] == velha[0, 1] && velha[0, 0] == velha[0, 2] && velha[0, 0] != ' ')
                {
                    Console.WriteLine(" O Jogador " + velha[0, 0] + " GANHOU A PARTIDA !!!");
                    Console.WriteLine("\n Aperte qualquer tecla para reiniciar");
                    Console.ReadKey();
                    Iniciar();


                }

                if (velha[1, 0] == velha[1, 1] && velha[1, 0] == velha[1, 2] && velha[1, 0] != ' ')
                {
                    Console.WriteLine(" O Jogador " + velha[1, 0] + " GANHOU A PARTIDA !!!");
                    Console.WriteLine("\n Aperte qualquer tecla para reiniciar");
                    Console.ReadKey();
                    Iniciar();

                }

                if (velha[2, 0] == velha[2, 1] && velha[2, 0] == velha[2, 2] && velha[2, 0] != ' ')
                {
                    Console.WriteLine(" O Jogador " + velha[2, 0] + " GANHOU A PARTIDA !!!");
                    Console.WriteLine("\n Aperte qualquer tecla para reiniciar");
                    Console.ReadKey();
                    Iniciar();

                }

            }

            void VerVertical(char[,] velha)
            {
                if (velha[0, 0] == velha[1, 0] && velha[0, 0] == velha[2, 0] && velha[0, 0] != ' ')
                {
                    Console.WriteLine(" O Jogador " + velha[0, 0] + " GANHOU A PARTIDA !!!");
                    Console.WriteLine("\n Aperte qualquer tecla para reiniciar");
                    Console.ReadKey();
                    Iniciar();
                }


                if (velha[0, 1] == velha[1, 1] && velha[0, 1] == velha[2, 1] && velha[0, 1] != ' ')
                {
                    Console.WriteLine(" O Jogador " + velha[0, 0] + " GANHOU A PARTIDA !!!");
                    Console.WriteLine("\n Aperte qualquer tecla para reiniciar");
                    Console.ReadKey();
                    Iniciar();
                }


                if (velha[0, 2] == velha[1, 2] && velha[0, 2] == velha[2, 2] && velha[0, 2] != ' ')
                {
                    Console.WriteLine(" O Jogador " + velha[0, 0] + " GANHOU A PARTIDA !!!");
                    Console.WriteLine("\n Aperte qualquer tecla para reiniciar");
                    Console.ReadKey();
                    Iniciar();


                }
            }

            void VerDiagonal(char[,] velha)
            {

                if (velha[0, 0] == velha[1, 1] && velha[0, 0] == velha[2, 2] && velha[0, 0] != ' ')
                {
                    Console.WriteLine("O Jogador " + velha[0, 0] + " GANHOU A PARTIDA !!!");
                    Console.WriteLine("\n Aperte qualquer tecla para reiniciar");
                    Console.ReadKey();
                    Iniciar();
                }

                if (velha[2, 0] == velha[1, 1] && velha[2, 0] == velha[0, 2] && velha[2, 0] != ' ')
                {
                    Console.WriteLine("O Jogador " + velha[0, 0] + "\n !!! GANHOU A PARTIDA !!!");
                    Console.WriteLine("\n Aperte qualquer tecla para reiniciar");
                    Console.ReadKey();
                    Iniciar();
                }
                
            }

           /*else*/ void Veia()
            {   if (cont == 9 )
                {

                    Console.WriteLine("!! Deu Véia !!!");
                    Console.WriteLine("\n Aperte qualquer tecla para reiniciar");
                    Console.ReadKey();
                    Iniciar();
                }
            }

            void Tabuleiro()
            {
                Console.Clear();

                Console.WriteLine(" Posições do jogo\n" +
                    "\n    7 | 8 | 9 \n" +
                  "   -----------\n    4 | 5 | 6 \n" +
                  "   -----------\n    1 | 2 | 3 \n\n\n" +
                  " Posições em tempo real");

                Console.WriteLine("\n    {0} | {1} | {2} \n" +
                    "   -----------\n    {3} | {4} | {5} \n" +
                    "   -----------\n    {6} | {7} | {8} \n\n\n",
               velha[0, 0], velha[0, 1], velha[0, 2],
               velha[1, 0], velha[1, 1], velha[1, 2],
               velha[2, 0], velha[2, 1], velha[2, 2]);

                Console.WriteLine("\n" + cont);

            }
             
        }
   
    }
}