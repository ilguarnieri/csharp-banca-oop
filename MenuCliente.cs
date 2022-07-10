using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class MenuCliente : Menu
    {
        public MenuCliente(Banca banca) : base(banca)
        {

        }


        public void Cliente(Cliente cliente)
        {
            Menu.HeaderUtente(cliente);

            string[] menuCliente =
            {
                "Informazioni cliente",
                "Modifica cliente",
                "Aggiungi prestito",
                "Lista prestiti",
                "Elimina cliente",
                "Torna al menù principale\n"
            };

            Menu.StampaMenu(menuCliente);

            int choice = Menu.LoopChoice(menuCliente.Length);

            switch (choice)
            {
                case 1:
                    cliente.InfoCliente(base.banca);
                    break;
                case 2:
                    cliente.ModificaCliente(base.banca);
                    break;
                case 3:
                    banca.AddPrestito(cliente);
                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:
                    Console.Clear();
                    Menu.Start(base.banca);
                    break;
            }
        }
    }
}
