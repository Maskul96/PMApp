

namespace PMApp.Entities
{
    public class Manager : Employee
    {
        public string? Name { get; set; }

        public override string ToString()
        {
            return base.ToString() + "Manager";
        }
    }
}
