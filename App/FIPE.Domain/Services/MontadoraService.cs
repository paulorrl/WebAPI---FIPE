using System.Collections.Generic;
using FIPE.Domain.Entities;
using FIPE.Domain.Interfaces.Repositories;
using FIPE.Domain.Interfaces.Services;

namespace FIPE.Domain.Services
{
    public class MontadoraService : IMontadoraService
    {
        private readonly IMontadoraRepository _montadoraRepository;

        public MontadoraService(IMontadoraRepository montadoraRepository)
        {
            _montadoraRepository = montadoraRepository;
        }

        public IEnumerable<Montadora> GetAll()
        {
            return _montadoraRepository.GetAll();
        }
    }
}