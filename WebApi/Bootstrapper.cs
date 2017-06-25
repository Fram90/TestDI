using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleInjector;
using Database;
using Infrastructure;
using SimpleInjector.Integration.Web;

namespace WebApi
{
    public static class Bootstrapper
    {
        public static Container container;
        public static void Configure()
        {
            container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            container.Register<IContext, Db>(Lifestyle.Scoped);
            container.Register<UnitOfWork>(Lifestyle.Scoped);

            container.Verify();

        }
    }
}