
namespace PMApp.Entities
{
    //Pracownik posiadac będzie cechy jak Imie i Nazwisko oraz zajmowane stanowisko w pracy
    public class Employee :EntityBase
    {
        public string? FirstName { get; set; } // Znak zapytania "?" - zgadzamy się na wartość NULL propercji FirstName

        public string? Name { get; set; }

        public string? JobTitle { get; set; }

        //przeciążenie metody ToString
        public override string ToString() // lub skrócony zapis zwracania wartości za pomoca operatora "=>" zamiast return
        {
            return $"Id: {Id}, FirstName: {FirstName}, Name: {Name}, JobTitle: {JobTitle}";
        }

    }
}
