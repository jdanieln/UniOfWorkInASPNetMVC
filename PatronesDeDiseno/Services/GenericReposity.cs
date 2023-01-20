using Microsoft.EntityFrameworkCore;
using PatronesDeDiseno.Data;

namespace PatronesDeDiseno.Services
{
    public class GenericReposity<T> : IGenericRepository<T> where T : class
    {
        protected PatronesDeDisenoContext _contex;
        internal DbSet<T> _dbSet;
        public GenericReposity(PatronesDeDisenoContext context)
        {
            _contex= context;
            _dbSet = context.Set<T>();
        }

        public virtual void Add(T entity)
        {
           _dbSet.Add(entity);
        }

        public virtual async void Delete(int id)
        {
           var entity = await _dbSet.FindAsync(id);

            if (entity == null)
                throw new Exception($"La entidad con el id { id.ToString() } no existe");

            _dbSet.Remove(entity);
        }

        public virtual async Task<IEnumerable<T>> GetAllSync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual void Update(T entity)
        {
            _contex.Entry(entity).State = EntityState.Modified;
        }
    }
}
