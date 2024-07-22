
using Microsoft.EntityFrameworkCore;
using PMApp.Entities;

namespace PMApp.Repositories
{
    public class SqlRepositoryInMemory
    {
        private readonly DbContext _dbcontext;
        private readonly DbSet<Employee> _dbSet;

        public SqlRepositoryInMemory(DbContext dbContext)
        {
            _dbcontext = dbContext;
            _dbSet = _dbcontext.Set<Employee>();
        }

        public void Add(Employee item)
        {
            _dbSet.Add(item);
        }

        public void Remove(Employee item)
        {
            _dbSet.Remove(item);
        }

        public void Save()
        {
            _dbcontext.SaveChanges();
        }

        public Employee? GetById(int id)
        {
            return _dbSet.Find(id);
        }

    }
}
