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

    }
}