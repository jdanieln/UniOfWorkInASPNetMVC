using PatronesDeDiseno.Data;
using PatronesDeDiseno.Services;

namespace PatronesDeDiseno.Configuration
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly PatronesDeDisenoContext _context;
        public IProductRepository ProductRepository { get; private set; }

        public ICategoryRepository CategoryRepository { get; private set; }

        public UnitOfWork(PatronesDeDisenoContext context)
        {
            _context = context;
            ProductRepository = new ProductRepository(_context);
            CategoryRepository = new CategoryRepository(_context);
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
