using Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Db : DbContext, IContext
    {
        public DbSet<Model> Models { get; set; }

        public Db():base("TestDb")
        {
            
        }
    }



    public interface IContext : IDisposable
    {
        DbSet<Model> Models { get; set; }
        int SaveChanges();
    }
}
