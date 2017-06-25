using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Database.Models;

namespace Infrastructure
{
    public class TestRepo
    {
        private IContext _context;

        public TestRepo(IContext context)
        {
            _context = context;
        }

        public void AddModel(string name)
        {
            _context.Models.Add(new Model() {Id = Guid.NewGuid(), Name = name});
        }
    }
}
