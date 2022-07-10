namespace csharp_banca_oop
{
    public class Prestito
    {
        protected int Id { get; private set; }
        public Cliente Intestatario { get; private set; }
        public uint Totale { get; private set; }
        public uint RateTotali { get; private set; }
        public uint RatePagate { get; private set; }
        public DateTime DataInizio { get; private set; }
        public DateTime DataFine { get; private set; }



    }
}