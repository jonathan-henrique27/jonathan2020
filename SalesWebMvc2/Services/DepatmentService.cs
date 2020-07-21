using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc2.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc2.Services
{
    public class DepatmentService
    {
        private readonly SalesWebMvc2Context _context;

        public DepatmentService(SalesWebMvc2Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
