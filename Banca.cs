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





    }
}
