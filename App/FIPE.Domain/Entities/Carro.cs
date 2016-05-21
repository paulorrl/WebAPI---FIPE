using System.Collections.Generic;

namespace FIPE.Domain.Entities
{
    public class Carro
    {
        public int CarroId { get; set; }

        public string Nome { get; set; }

        public int MontadoraId { get; set; }

        public virtual Montadora Montadora { get; set; }

        public virtual IEnumerable<AnoModelo> AnoModelos { get; set; }
    }
}