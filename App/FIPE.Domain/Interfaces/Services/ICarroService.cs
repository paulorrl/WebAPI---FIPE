using System.Collections.Generic;
using FIPE.Domain.Entities;

namespace FIPE.Domain.Interfaces.Services
{
    public interface ICarroService
    {
        IEnumerable<Carro> GetByMontadora(int montadoraId);
    }
}