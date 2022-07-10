namespace csharp_banca_oop
{
    public class Prestito
    {
        public int Id { get; private set; }
        public Cliente Intestatario { get; private set; }
        public uint Importo { get; private set; }
        public int RateTotali { get; private set; }
        public int RatePagate { get; private set; }
        public DateTime DataInizio { get; private set; }
        public DateTime DataFine { get; private set; }


        public Prestito(int id, Cliente intestatario, uint importo, int rateTotali, int ratePagate, DateTime dataInizio, DateTime dataFine)
        {
            this.Id = id;
            this.Intestatario = intestatario;
            this.Importo = importo;
            this.RateTotali = rateTotali;
            this.RatePagate = ratePagate;
            this.DataInizio = dataInizio;
            this.DataFine = dataFine;
        }



    }
}