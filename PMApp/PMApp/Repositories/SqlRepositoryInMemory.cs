
using Microsoft.EntityFrameworkCore;
using PMApp.Entities;

namespace PMApp.Repositories
{
    public class SqlRepositoryInMemory<T> : IRepository<T> where T : class, IEntity, new()
    {
        private readonly DbContext _dbcontext;
        private readonly DbSet<T> _dbSet;

        public SqlRepositoryInMemory(DbContext dbContext)
        {
            _dbcontext = dbContext;
            _dbSet = _dbcontext.Set<T>(); //dane dot. tabeli przechowywanej w pamięci EFC
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.OrderBy(x => x.Id).ToList();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public void Save()
        {
            _dbcontext.SaveChanges();
        }

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

    }
}
