using Database.Models;

namespace Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Db context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Models.AddOrUpdate(x => x.Name,
                new Model() { Id = Guid.NewGuid(), Name = "Test1" },
                new Model() { Id = Guid.NewGuid(), Name = "Test2" },
                new Model() { Id = Guid.NewGuid(), Name = "Test3" },
                new Model() { Id = Guid.NewGuid(), Name = "Test4" });
        }
    }
}
