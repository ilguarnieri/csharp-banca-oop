using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Menu
    {
        public static void LogoBanca(string nomeBanca)
        {
            Console.WriteLine($"*** {nomeBanca.ToUpper()} ***");
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ \n");
        }



        public static void StampaMenu(string[] menuItem)
        {
            for (int i = 0; i < menuItem.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menuItem[i]}");
            }
        }


        public static int LoopChoice(int options)
        {
            int choice;
            do
            {
                string input = Console.ReadLine();
                bool isNumber = int.TryParse(input, out choice);

                if (String.IsNullOrEmpty(input) || !isNumber)
                {
                    input = "0";
                }

                choice = Convert.ToByte(input);

                if (choice == 0 || choice > options)
                {
                    Console.WriteLine("La voce di menu selezionata non esite!");
                    Console.WriteLine("Inserisci una voce valida...\n");
                }
            } while (choice == 0 || choice > options);

            return choice;
        }



        public static void PressAllKey()
        {
            Console.WriteLine("Premi qualsiasi tasto per continuare...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
