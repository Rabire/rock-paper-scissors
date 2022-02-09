using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIERREPAPIERCISEAUX
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {


                    Console.Write("Tu joues contre BOB, choisis entre PIERRE, PAPIER et CISEAUX:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "PIERRE";
                            Console.WriteLine("Bob a choisi PIERRE");
                            if (inputPlayer == "PIERRE")
                            {
                                Console.WriteLine("EGALITE !\n\n");
                            }
                            else if (inputPlayer == "PAPIER")
                            {
                                Console.WriteLine("Tu as gagné !\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "CISEAUX")
                            {
                                Console.WriteLine("Bob a gagné !\n\n");
                                 scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPIER";
                            Console.WriteLine("Bob a choisi PAPIER");
                            if (inputPlayer == "PAPIER")
                            {
                                Console.WriteLine("EGALITE !\n\n");
                            }
                            else if (inputPlayer == "PIERRE")
                            {
                                Console.WriteLine("Bob a gagné !\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "CISEAUX")
                            {
                                Console.WriteLine("Tu a gagné !\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "CISEAUX";
                            Console.WriteLine("Bob a choisi CISEAUX");
                            if (inputPlayer == "CISEAUX")
                            {
                                Console.WriteLine("EGALITE !\n\n");
                            }
                            else if (inputPlayer == "PIERRE")
                            {
                                Console.WriteLine("Tu a gagné !\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPIER")
                            {
                                Console.WriteLine("Bob a gagné !\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Entrée invalide !");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tTOI:\t{0}\tBOB:\t{1}", scorePlayer, scoreCPU);

                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("C'est fini, tu remportes le duel !");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("C'est fini, tu perds le duel !");
                }
                else
                {

                }

                Console.WriteLine("Rejouer ? (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }

            }
        }
    }
}
