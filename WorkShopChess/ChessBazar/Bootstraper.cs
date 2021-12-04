using Autofac;
using ChessBazar.Services;
using ChessBazar.Services.Contracts;
using ChessBazar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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

            builder.RegisterType<ChessViewGridModel>().AsSelf();
            builder.RegisterType<IBoardGeneratorService>().As<BoardGeneratorService>();
            Container = builder.Build() ;            
        }
    }
}
