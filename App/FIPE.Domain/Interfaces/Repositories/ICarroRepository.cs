using System;
using System.Collections.Generic;
using FIPE.Domain.Entities;

namespace FIPE.Domain.Interfaces.Repositories
{
    public interface ICarroRepository : IDisposable
    {
        IEnumerable<Carro> GetByMontadora(int montadoraId);
    }
}