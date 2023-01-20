using Microsoft.EntityFrameworkCore;
using PatronesDeDiseno.Data;
using PatronesDeDiseno.Models;

namespace PatronesDeDiseno.Services
{
    public class ProductRepository: GenericReposity<Product>, IProductRepository
    {
        private readonly PatronesDeDisenoContext _context;
        public ProductRepository(PatronesDeDisenoContext context): base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Product>> GetAllSync()
        {
            var patronesDeDisenoContext = _context.Product.Include(p => p.Category);
           return await patronesDeDisenoContext.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _dbSet.Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
