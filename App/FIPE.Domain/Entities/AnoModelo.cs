namespace FIPE.Domain.Entities
{
    public class AnoModelo
    {
        public int AnoModeloId { get; set; }

        public int CarroId { get; set; }

        public int Ano { get; set; }

        public virtual Carro Carro { get; set; }
    }
}