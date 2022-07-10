using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class MainMenu
    {

        public static void Start(Banca banca)
        {
            Menu.LogoBanca(banca.Nome);

            string[] menuStart = {
                "Aggiungere nuovo cliente",
                "Lista clienti",
                "Ricerca cliente",
                "Ricerca prestiti cliente\n"};

            Menu.StampaMenu(menuStart);

            int choice = Menu.LoopChoice(menuStart.Length);

            switch (choice)
            {
                case 1:
                    banca.AddCliente();
                    break;
                case 2:

                    break;
            }


        }
        











    }
}
