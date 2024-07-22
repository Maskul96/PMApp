
namespace PMApp.Entities
{
    //Definicja modelu danych
    public class Employee :EntityBase
    {
        public string? FirstName { get; set; } // Znak zapytania "?" - zgadzamy się na wartość NULL propercji FirstName

        public string? Name { get; set; }

        public string? JobTitle { get; set; }

        public int AssignedWorkingTime { get; set; }
        public int UsedWorkingTime { get; set; }

        //przeciążenie metody ToString
        public override string ToString() // lub skrócony zapis zwracania wartości za pomoca operatora "=>" zamiast return
        {
            return $"Id: {Id}, FirstName: {FirstName}, Name: {Name}, JobTitle: {JobTitle}, Assigned Working Time: {AssignedWorkingTime}" +
                $"UsedWorkingTime: {UsedWorkingTime}";
        }

    }
}
