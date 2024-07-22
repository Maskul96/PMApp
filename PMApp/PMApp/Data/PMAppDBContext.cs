using Microsoft.EntityFrameworkCore;
using PMApp.Entities;
using PMApp.Repositories;
using System;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace PMApp.Data
{
    #region krótkie wyjaśnienie DBContext i DBSet
    //DbContext: Służy do konfigurowania połączenia z bazą danych, zarządzania encjami oraz wykonywania operacji CRUD i zapytań.
    //DbSet: Reprezentuje kolekcję encji (tabelę w bazie danych) i umożliwia operacje CRUD oraz wykonywanie zapytań na tych encjach.
    // Każda właściwość DbSet w DbContext odpowiada tabeli w bazie danych
    #endregion
    public class PMAppDBContext :DbContext
    {
        DbSet<Employee> Employees => Set<Employee>();
        DbSet<Manager> Manager => Set<Manager>();
        DbSet<Project> Projects => Set<Project>();
        //np. Set<Project>() jest metodą w DbContext, która zwraca DbSet<Project>. Ta metoda umożliwia dostęp do wszystkich obiektów Project przechowywanych w bazie danych i wykonywanie operacji na tabeli Projects

        #region krótki opis metody OnConiguring
        //Metoda OnConfiguring w DbContext jest używana do konfigurowania opcji dla kontekstu bazy danych.Jest to miejsce, w którym można ustawić szczegóły połączenia z bazą danych, dostawcę bazy danych, 
        //    logowanie i inne opcje konfiguracji specyficzne dla danego kontekstu.Metoda OnConfiguring jest wywoływana automatycznie przez Entity Framework Core podczas inicjalizacji instancji DbContext.
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("PMAppDatabase");

        }
    }
}
