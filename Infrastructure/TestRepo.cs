using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace Infrastructure
{
    public class TestRepo
    {
        private IContext _context;

        public TestRepo(IContext context)
        {
            _context = context;
        }
    }
}
