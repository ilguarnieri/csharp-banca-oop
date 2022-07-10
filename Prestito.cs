namespace csharp_banca_oop
{
    public class Prestito
    {
        public int Id { get; private set; }
        public Cliente Intestatario { get; private set; }
        public uint Importo { get; private set; }
        public byte Interesse { get; private set; }
        public double ImportoConInteresse { get; private set; }
        public int RateTotali { get; private set; }        
        public double ImportoRata { get; private set; }
        public int RatePagate { get; private set; }
        public DateTime DataInizio { get; private set; }
        public DateTime DataFine { get; private set; }

        public Prestito (int id, Cliente intestatario, uint importo, byte interesse, double importoConInteresse, int rateTotali, double importoRata, int ratePagate, DateTime dataInizio, DateTime dataFine)
        {
            Id = id;
            Intestatario = intestatario;
            Importo = importo;
            Interesse = interesse;
            ImportoConInteresse = importoConInteresse;
            RateTotali = rateTotali;
            ImportoRata = importoRata;
            RatePagate = ratePagate;
            DataInizio = dataInizio;
            DataFine = dataFine;
        }
    }
}