using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Menu
    {

        public Banca banca;

        public Menu(Banca banca)
        {
            this.banca = banca;
        }


        public void LogoBanca()
        {
            Console.WriteLine($"*** {this.banca.Nome} ***");
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ \n");
        }



        public static void HeaderUtente(Cliente cliente)
        {
            Console.WriteLine($"*** CONTO DI {cliente.Nome.ToUpper()} {cliente.Cognome.ToUpper()} ***");
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



        public static void PressAllKey(string nextStop)
        {
            Console.WriteLine($"Premi qualsiasi tasto per {nextStop}...");
            Console.ReadKey();
            Console.Clear();
        }




        public static void Start(Banca banca)
        {
            banca.menu.LogoBanca();

            string[] menuStart =
            {
                "Aggiungere nuovo cliente",
                "Lista clienti",
                "Ricerca cliente",
                "Ricerca prestiti cliente\n"
            };

            Menu.StampaMenu(menuStart);

            int choice = Menu.LoopChoice(menuStart.Length);

            switch (choice)
            {
                case 1:
                    banca.AddCliente();
                    break;
                case 2:
                    banca.ListaClienti();
                    break;
                case 3:
                    banca.RicercaCliente();
                    break;
            }

        }
    }
}
