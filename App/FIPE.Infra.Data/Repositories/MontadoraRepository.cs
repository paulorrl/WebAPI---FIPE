using System;
using System.Collections.Generic;
using FIPE.Domain.Entities;
using FIPE.Domain.Interfaces.Repositories;
using FIPE.Infra.Data.Context;

namespace FIPE.Infra.Data.Repositories
{
    public class MontadoraRepository : IMontadoraRepository
    {
        private readonly FipeDb _context;

        public MontadoraRepository(FipeDb context)
        {
            _context = context;
        }

        public IEnumerable<Montadora> GetAll()
        {
            return _context.Montadoras;
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}