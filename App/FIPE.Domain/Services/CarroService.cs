using System.Collections.Generic;
using FIPE.Domain.Entities;
using FIPE.Domain.Interfaces.Repositories;
using FIPE.Domain.Interfaces.Services;

namespace FIPE.Domain.Services
{
    public class CarroService : ICarroService
    {
        private readonly ICarroRepository _carroRepository;

        public CarroService(ICarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public IEnumerable<Carro> GetByMontadora(int montadoraId)
        {
            return _carroRepository.GetByMontadora(montadoraId);
        }
    }
}