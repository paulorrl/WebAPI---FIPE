using FIPE.Domain.Interfaces.Repositories;
using FIPE.Domain.Interfaces.Services;
using FIPE.Domain.Services;
using FIPE.Infra.Data.Context;
using FIPE.Infra.Data.Repositories;
using SimpleInjector;

namespace FIPE.Infra.CrossCutting.Ioc
{
    public static class DependencyResolver
    {
        public static void RegisterServices(Container container)
        {
            container.Register<FipeDb>(Lifestyle.Scoped);

            container.Register<IMontadoraService, MontadoraService>(Lifestyle.Scoped);
            container.Register<ICarroService, CarroService>(Lifestyle.Scoped);

            container.Register<IMontadoraRepository, MontadoraRepository>(Lifestyle.Scoped);
            container.Register<ICarroRepository, CarroRepository>(Lifestyle.Scoped);
        }
    }
}