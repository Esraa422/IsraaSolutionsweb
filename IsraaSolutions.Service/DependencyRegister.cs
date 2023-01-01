using Autofac;
using IsraaApp.Core.Cache;
using IsraaApp.Data;

namespace IsraaApp.Service
{
    public class DependencyRegister
    {
        public static void Register(ContainerBuilder builder)
        {
            builder.RegisterType<DataContext>().As<IDataContext>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterType<MemoryCacheManager>().As<ICacheManager>().SingleInstance();
        }
    }
}