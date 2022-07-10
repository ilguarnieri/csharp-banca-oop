using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Banca
    {
        public string Nome { get; private set; }

        public List<Cliente> clienti;
        public List<Prestito> prestiti;


        public Banca(string nome)
        {
            this.Nome = nome;
            this.clienti = new List<Cliente>();
            this.prestiti = new List<Prestito>();
        }


        public Cliente CreaCliente()
        {
            Console.WriteLine("Creazione nuovo cliente\n");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Cognome: ");
            string cognome = Console.ReadLine();

            Console.Write("Codice Fiscale: ");
            string codiceFiscale = Console.ReadLine();

            Console.Write("Stipendio annuo: ");
            float stipendio = float.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nome, cognome, codiceFiscale, stipendio);

            return cliente;
        }



        public void AddCliente()
        {
            Console.Clear();
            Menu.LogoBanca(this.Nome);
            Cliente nuovoCliente = this.CreaCliente();
            this.clienti.Add(nuovoCliente);
            Console.Clear();
            Console.WriteLine("CLIENTE CREATO CON SUCCESSO!\n");
            Menu.PressAllKey();
            MainMenu.Start(this);
        }



        public void ListaClienti()
        {
            Console.Clear();
            Menu.LogoBanca(this.Nome);

            Console.WriteLine("LISTA CLIENTI\n");

            int i = 0;
            foreach (Cliente cliente in this.clienti)
            {
                i++;
                Console.WriteLine($"{i} - - - - - - - - - - - - - - -");
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"Cognome: {cliente.Cognome}");
                Console.WriteLine($"Codice Fiscale: {cliente.CodiceFiscale}");
                Console.WriteLine($"Stipendio annuo: {cliente.Stipendio}\n");
            }

            Console.WriteLine("Seleziona un cliente");
            int choice = Menu.LoopChoice(clienti.Count);

            Console.Clear();
            MenuCliente.Cliente(this, clienti[choice - 1]);
        }



        public void RicercaCliente()
        {
            Console.Clear();
            Menu.LogoBanca(this.Nome);

            Console.WriteLine("RICERCA CLIENTE\n");

            Console.Write("Codice Fiscale: ");
            string cf = Console.ReadLine();

            bool checkCliente = false;

            for (int i = 0; i < clienti.Count; i++)
            {
                if (cf == clienti[i].CodiceFiscale)
                {
                    checkCliente = true;
                    Console.Clear();
                    MenuCliente.Cliente(this, clienti[i]);
                    break;
                }
            }

            if (!checkCliente)
            {
                Console.Clear();
                Console.WriteLine("CLIENTE NON TROVATO!\n");
                Menu.PressAllKey();
                MainMenu.Start(this);
            }


        }





    }
}
