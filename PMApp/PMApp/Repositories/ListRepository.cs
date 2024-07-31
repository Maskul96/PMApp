
using System.Collections.Generic;
using PMApp.Entities;

namespace PMApp.Repositories
{

    //GenericRepository będzie przyjmować tylko klasy, które implementują EntityBase
    //parametrów generycznych może być kilka
    //Czyli baza danych umieszczana lokalnie w liście
    public class ListRepository<T> : IRepository<T>  where T : class, IEntity, new() //ograniczenie new() mówi o tym, że klasa, która dziedziczy po IEntity  musi mieć bezparametrowy konstruktor
    {
        private readonly List<T> _items = new List<T>();

        //klasa musi zawierać metody dodawania użytkowników, zapisu, edycji i usuwania
        //Poniżej przykładowe stworzenie obiektu bez parametrów
        //public TEntity CeateNewItem()
        //{
        //    return new TEntity();
        //}

        //deklaracja metody GetAll do wyciągnięcia całej kolekcji danych

        public IEnumerable<T> GetAll()
        {
            return _items.ToList(); //dzięki metodize ToList() tworzy nam się nowy obiekt dzięki temu, ktoś kto pobierze tą listę będzie pracował tak jakby na jej kopii
        }

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Save() //UNUSED
        {
            //foreach (var item in _items)
            //{
            //    Console.WriteLine(item);
            //}
        }

        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }

        //    public void Edit(Employee employee, string FirstName, string Name, string JobTitle)
        //{
        //    var emp = GetById(employee.Id);
        //    emp.FirstName = FirstName;
        //    emp.Name = Name;
        //    emp.JobTitle = JobTitle;
        //    _employees.Add(emp);
        //}
    }
}

