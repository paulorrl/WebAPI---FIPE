using System.Data.Entity;
using FIPE.Domain.Entities;

namespace FIPE.Infra.Data.Context
{
    public class FipeDb : DbContext
    {
        public FipeDb()
            : base("")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Montadora> Montadoras { get; set; }

        public DbSet<Carro> Carros { get; set; }
    }
}