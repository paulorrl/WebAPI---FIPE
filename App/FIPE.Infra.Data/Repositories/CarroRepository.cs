using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FIPE.Domain.Entities;
using FIPE.Domain.Interfaces.Repositories;
using FIPE.Infra.Data.Context;

namespace FIPE.Infra.Data.Repositories
{
    public class CarroRepository : ICarroRepository
    {
        private readonly FipeDb _context;

        public CarroRepository(FipeDb context)
        {
            _context = context;
        }

        public IEnumerable<Carro> GetByMontadora(int montadoraId)
        {
            return _context.Carros.Where(x => x.MontadoraId == montadoraId).Include("AnoModeloCarro");
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}