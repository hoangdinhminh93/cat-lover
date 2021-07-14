using System;
using Autofac;
using CatLover.ViewModels;

namespace CatLover.Services
{
    public class AppContainer
    {
        private static IContainer container;

        public AppContainer()
        {
            // Services
            var builder = new ContainerBuilder();
            builder.RegisterType<CatService>().As<ICatService>().SingleInstance();

            // ViewModels
            builder.RegisterType<MainViewModel>().SingleInstance();
            builder.RegisterType<BreedDetailViewModel>().SingleInstance();

            container = builder.Build();
        }

        public T Resolve<T>() => container.Resolve<T>();

        public object Resolve(Type type) => container.Resolve(type);
    }
}