using System.Collections.Generic;
using FIPE.Domain.Entities;

namespace FIPE.Domain.Interfaces.Repositories
{
    public interface IMontadoraRepository
    {
        IEnumerable<Montadora> GetAll();
    }
}