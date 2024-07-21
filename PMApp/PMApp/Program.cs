using PMApp.Entities;
using PMApp.Repositories;
using System;

var employeeRepository = new GenericRepository<Employee, int>();
//var p1 = new Person(); // zdefiniowanie nowego obiektu klasy bez podania właściwości
//var p2 = new Person() { FirstName = "Grace", LastName = "Hopper" }; podanie właściwości obiektu
employeeRepository.Add(new Employee() { FirstName = "Kamil", Name = "Maskulanis", JobTitle = "Programista" });
employeeRepository.Add(new Employee() { FirstName = "Krzysztof", Name = "Miller", JobTitle = "Projektant Elektryki" });
employeeRepository.Add(new Employee() { FirstName = "Michał", Name = "Szyszka", JobTitle = "Konstruktor" });
employeeRepository.Save();

