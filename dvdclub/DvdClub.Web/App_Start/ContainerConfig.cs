using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using DvdClub.Common.Services;
using DvdClub.Core.Interfaces;
using DvdClub.Infrastructure.Data;
using DvdClub.Infrastructure.Services;
using DvdClub.Web.Logging;
using DvdClub.Web.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DvdClub.Web {

    public class ContainerConfig {

        internal static void RegisterContainer(HttpConfiguration httpConfiguration) {//object configuration
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<MoviesService>()
                   .As<IMoviesService>()
                   .InstancePerRequest();
            builder.RegisterType<RentalsService>()
                   .As<IRentalsService>()
                   .InstancePerRequest();
            builder.RegisterType<UsersService>()
                   .As<IUsersService>()
                   .InstancePerRequest();
            builder.RegisterType<PaginationService>()
                   .As<IPaginationService>()
                   .InstancePerRequest();
            builder.RegisterType<LoggingService>()
                   .As<ILoggingService>()
                   .InstancePerRequest();
            builder.Register(m => MapperInit.Init())
                .AsSelf()
                .SingleInstance();
            builder.Register(m => m.Resolve<MapperConfiguration>().CreateMapper(m.Resolve))
                .As<IMapper>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DvdClubDbContext>().InstancePerRequest();



            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
