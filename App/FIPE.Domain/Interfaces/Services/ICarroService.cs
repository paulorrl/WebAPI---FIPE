using System;
using System.Collections.Generic;
using FIPE.Domain.Entities;

namespace FIPE.Domain.Interfaces.Services
{
    public interface ICarroService : IDisposable
    {
        IEnumerable<Carro> GetByMontadora(int montadoraId);
    }
}