using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_rest_repository.Data;
using webapi_rest_repository.DataInterfaces;
using webapi_rest_repository.Models;

namespace webapi_rest_repository.Repository
{
    public class ProductRepository : IProductInterfaces
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            return await _context.Products.AsNoTracking().ToListAsync();
        }
    }
}
