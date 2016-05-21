using System.Collections.Generic;
using FIPE.Domain.Entities;

namespace FIPE.Domain.Interfaces.Services
{
    public interface IMontadoraService
    {
        IEnumerable<Montadora> GetAll();
    }
}