using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc2.Models;
namespace SalesWebMvc2.Services
{
    public class DepatmentService
    {
        private readonly SalesWebMvc2Context _context;

        public DepatmentService(SalesWebMvc2Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
