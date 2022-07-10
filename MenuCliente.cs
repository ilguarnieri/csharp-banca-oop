using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class MenuCliente
    {

        public static void Cliente(Banca banca, Cliente cliente)
        {
            Menu.LogoBanca(banca.Nome);

            Console.WriteLine($"CONTO DI {cliente.Nome.ToUpper()} {cliente.Cognome.ToUpper()}\n");

            string[] menuCliente =
            {
                "Modifica cliente",
                "Aggiungi prestito",
                "Lista prestiti",
                "Elimina client",
                "Torna al menù principale\n"
            };

            Menu.StampaMenu(menuCliente);

            int choice = Menu.LoopChoice(menuCliente.Length);
        }
    }
}
