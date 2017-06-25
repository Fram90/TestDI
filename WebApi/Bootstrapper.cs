using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleInjector;
using Database;

namespace WebApi
{
    public static class Bootstrapper
    {
        static Container container;
        public static void Configure()
        {
            container = new Container();

            container.Register<IContext, Db>();

            container.Verify();

        }
    }
}