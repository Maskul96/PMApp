﻿
using System.Collections.Generic;
using PMApp.Entities;

namespace PMApp.Repositories
{
    public class EmployeeRepository
    {
        //GenericRepository będzie przyjmować tylko klasy, które implementują EntityBase
        //TKey to drugi parametr generyczny, który też może mieć jakieś swoje ograniczenia
        public class GenericRepository<TEntity, TKey> where TEntity : class, IEntity, new() //ograniczenie new() mówi o tym, że klasa, która dziedziczy po IEntity  musi mieć bezparametrowy konstruktor
            where TKey : struct
        {
            public TKey? Key { get; set; }

            private readonly List<TEntity> _items = new List<TEntity>();

            //klasa musi zawierać metody dodawania użytkowników, zapisu, edycji i usuwania
            //Poniżej stworzenie obiektu bez parametrów
            public TEntity CeateNewItem()
            {
                return new TEntity();
            }

            public void Add(TEntity item)
            {
                item.Id = _items.Count + 1;
                _items.Add(item);
            }

            public void Remove(TEntity item)
            {
                _items.Remove(item);
            }

            public void Save()
            {
                foreach (var item in _items)
                {
                    Console.WriteLine(item);
                }
            }

            public TEntity GetById(int id)
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
}