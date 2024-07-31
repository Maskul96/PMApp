
using PMApp.Entities;

namespace PMApp.Repositories
{
    public interface IRepository<T> where T: class, IEntity
    {
        IEnumerable<T> GetAll(); //pobranie wszystkich elementów z repozystorium

        T GetById(int id);

        void Add(T item);

        void Remove(T item);

        void Save();



    }
}
