using Autofac;
using ChessBazar.Services;
using ChessBazar.Services.Contracts;
using ChessBazar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChessBazar
{
    public static class Bootstraper
    {
        public static IContainer  Container { get; set; }

        public static void Init()
        {
            var builder = new ContainerBuilder();
            var currentAssembly = Assembly.GetExecutingAssembly();

            //builder.RegisterType<ChessGridViewModel>().AsSelf();

            builder.RegisterAssemblyTypes(currentAssembly)
                .Where(t => t.Name.EndsWith("ViewModel"))
                .AsSelf();

            //Register all services with interfaces
            builder.RegisterAssemblyTypes(currentAssembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();

            Container = builder.Build() ;            
        }
    }
}
