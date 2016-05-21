using System.Collections.Generic;

namespace FIPE.Domain.Entities
{
    public class Montadora
    {
        public int MarcaId { get; set; }

        public string Nome { get; set; }

        public bool Principal { get; set; }

        public virtual IEnumerable<Carro> Carros { get; set; }
    }
}