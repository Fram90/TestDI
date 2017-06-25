using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace Infrastructure
{
    public class UnitOfWork : IDisposable
    {
        private readonly IContext _context;

        public TestRepo TestRepo;

        public UnitOfWork(IContext context)
        {
            _context = context;
            TestRepo = new TestRepo(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }


        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
