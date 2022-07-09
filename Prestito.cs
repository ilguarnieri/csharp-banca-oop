namespace csharp_banca_oop
{
    public class Prestito
    {
        public int Id { get; set; }
        public Cliente Intestatario { get; set; }
        public uint Totale { get; set; }
        public uint Rata { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }



    }
}