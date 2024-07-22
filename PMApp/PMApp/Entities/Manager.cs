

namespace PMApp.Entities
{
    //Definicja modelu danych
    public class Manager : Employee
    {
        public string? Name { get; set; }

        public override string ToString()
        {
            return base.ToString() + "Manager";
        }
    }
}
