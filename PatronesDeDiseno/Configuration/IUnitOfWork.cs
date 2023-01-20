using PatronesDeDiseno.Services;

namespace PatronesDeDiseno.Configuration
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        void Commit();
        void Dispose();
    }
}
