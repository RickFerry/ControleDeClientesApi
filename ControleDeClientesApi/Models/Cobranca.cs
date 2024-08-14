namespace ControleDeClientesApi.Models
{
    public class Cobranca
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Pago { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}