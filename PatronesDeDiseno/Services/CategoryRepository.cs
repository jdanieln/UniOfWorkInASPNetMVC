using PatronesDeDiseno.Data;
using PatronesDeDiseno.Models;

namespace PatronesDeDiseno.Services
{
    public class CategoryRepository: GenericReposity<Category>, ICategoryRepository
    {
        public CategoryRepository(PatronesDeDisenoContext context): base(context)
        {

        }
    }
}
