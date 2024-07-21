

using PMApp.Repositories;

namespace PMApp.Entities
{
    //klasa abstrakcyjna, bo nigdy nie bedziemy tworzyć modeli tej klasy
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
    }
}
