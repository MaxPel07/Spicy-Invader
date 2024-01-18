using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSpicyInvader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ShowMenu();
                
            } while (true);
        }

        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(
            "************* \n" +
            "SPICY INVADER \n" +
            "************* \n" +
            "[1] Jouer \n" +
            "[2] A propos \n" +
            "[3] quitter \n");

            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.KeyChar)
            {
                case '1':
                    DifficultyChoice();
                    Console.Clear();
                    break;

                case '2':
                    Informations();
                    break;

                case '3':
                    Environment.Exit(0);
                    break;
            }
            Console.ReadLine();
        }

        public static void DifficultyChoice()
        {
            Console.Clear();
            Console.WriteLine(
                "********************** \n" +
                "Choix de la difficulté \n" +
                "********************** \n" +
                "[1] mode facile \n" +
                "[2] mode difficile \n \n" +
                "Appuyer sur une touche pour revenir au menu");

            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.KeyChar)
            {
                case '1':
                    //HardMode();
                    break;

                case '2':
                    //EasyMode();
                    break;

                default:
                    ShowMenu();
                    break;
            }
            Console.ReadLine();
        }

        public static void Informations()
        {
            Console.Clear();
            Console.WriteLine(
                "Spicy Invader est un jeu basé sur le jeu, connu mondialement, Space Invaders \n");
        }
    }
}
