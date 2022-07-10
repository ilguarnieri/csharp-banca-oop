using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Banca
    {
        public string Nome { get; private set; }

        public List<Cliente> clienti;
        public List<Prestito> prestiti;
        public Menu menu;
        public MenuCliente menuCliente;

        public Banca(string nome)
        {
            this.Nome = nome;
            this.clienti = new List<Cliente>();
            this.prestiti = new List<Prestito>();

            menu = new Menu(this);
            menuCliente = new MenuCliente(this);
        }


        public Cliente CreaCliente()
        {
            Console.WriteLine("NUOVO CLIENTE\n");

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
            menu.LogoBanca();
            Cliente nuovoCliente = this.CreaCliente();
            this.clienti.Add(nuovoCliente);
            Console.Clear();
            Console.WriteLine("CLIENTE CREATO CON SUCCESSO!\n");
            Menu.PressAllKey("continuare");
            Menu.Start(this);
        }



        public void ListaClienti()
        {
            Console.Clear();
            menu.LogoBanca();

            Console.WriteLine("LISTA CLIENTI\n");

            int i = 0;
            foreach (Cliente cliente in this.clienti)
            {
                i++;
                Console.WriteLine($"{i} - - - - - - - - - - - - - - -");
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"Cognome: {cliente.Cognome}");
                Console.WriteLine($"Codice Fiscale: {cliente.CodiceFiscale}");
                Console.WriteLine($"Stipendio annuo: {cliente.Stipendio}EUR\n");
            }

            Console.WriteLine("Seleziona un cliente");
            int choice = Menu.LoopChoice(clienti.Count);

            Console.Clear();
            this.menuCliente.Cliente(clienti[choice - 1]);
        }



        public void RicercaCliente()
        {
            Console.Clear();
            menu.LogoBanca();

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
                    this.menuCliente.Cliente(clienti[i]);
                    break;
                }
            }

            if (!checkCliente)
            {
                Console.Clear();
                Console.WriteLine("CLIENTE NON TROVATO!\n");
                Menu.PressAllKey("continuare");
                Menu.Start(this);
            }
        }




        public Prestito NuovoPrestito(Cliente cliente)
        {
            Console.WriteLine("NUOVO PRESTITO\n");

            bool verifyID;
            int randomID;

            do
            {
                //CREAZIONE ID RANDOM ED UNIVOCO
                verifyID = false;

                randomID = new Random().Next(1, 2147483647);

                foreach(Prestito prestito1 in prestiti)
                {
                    if(prestito1.Id == randomID)
                    {
                        verifyID = true;
                        break;
                    }
                }

            } while (verifyID);

            Console.WriteLine($"Prestito ID: {randomID}");

            Console.WriteLine($"Intestatario: {cliente.Nome} {cliente.Cognome}");

            Console.Write("Inserire l'importo del prestito: ");
            uint importo = uint.Parse(Console.ReadLine());

            Console.Write("Rate totali: ");
            int rateTotali = byte.Parse(Console.ReadLine());

            DateTime dataInizio = DateTime.Now;

            DateTime dataFine = this.CalcoloFinePrestito(rateTotali, dataInizio);

            Prestito prestito = new Prestito(randomID, cliente, importo, rateTotali, 0, dataInizio, dataFine);

            return prestito;
        }



        public void AddPrestito(Cliente cliente)
        {
            Console.Clear();
            Menu.HeaderUtente(cliente);
            Prestito nuovoPrestito = this.NuovoPrestito(cliente);
            this.prestiti.Add(nuovoPrestito);
            Console.Clear();
            Console.WriteLine("PRESTITO CREATO CON SUCCESSO!\n");
            Menu.PressAllKey("continuare");
            //portare lista prestiti
        }



        public DateTime CalcoloFinePrestito(int rateTotali, DateTime dataInizio)
        {

            int anni = rateTotali / 12;
            Console.WriteLine(anni);

            int mesi = rateTotali % 12;
            Console.WriteLine(mesi);

            DateTime dataFine = dataInizio.AddYears(anni).AddMonths(mesi);


            return dataFine;
        }




    }
}
