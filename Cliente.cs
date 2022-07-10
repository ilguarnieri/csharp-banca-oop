namespace csharp_banca_oop
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public string CodiceFiscale { get; private set; }
        public float Stipendio { get; set; }

        public Cliente (string nome, string cognome, string codiceFiscale, float stipendio)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.CodiceFiscale = codiceFiscale;
            this.Stipendio = stipendio;
        }


        public void InfoCliente(Banca banca)
        {
            Console.Clear();
            Menu.HeaderUtente(this);

            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Cognome: {this.Cognome}");
            Console.WriteLine($"Codice Fiscale: {this.CodiceFiscale}");
            Console.WriteLine($"Stipendio annuo: {this.Stipendio} EUR\n");

            Menu.PressAllKey("tornare indietro");
            banca.menuCliente.Cliente(this);
        }


        public void ModificaCliente(Banca banca)
        {
            Console.Clear();
            Menu.HeaderUtente(this);

            Console.WriteLine("MODIFICA CLIENTE\n");
            Console.WriteLine("Stipendio annuo");
            Console.WriteLine($"Valore presente nel sistema: {this.Stipendio} EUR\n");

            Console.Write("Nuovo valore: ");
            float nuovoStipendio = float.Parse(Console.ReadLine());

            this.Stipendio = nuovoStipendio;

            Console.Clear();
            Console.WriteLine("CLIENTE MODIFICATO CON SUCCESSO!\n");

            Menu.PressAllKey("vedere tutte le info del cliente");
            this.InfoCliente(banca);
        }

    }
}