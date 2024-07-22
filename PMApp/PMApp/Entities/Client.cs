

namespace PMApp.Entities
{
    //klasa opisująca klientów biznesowych, którzy zlecają prace - definicja modelu danych
    public class Client : EntityBase
    {
        public string? NameOfClient { get; set; }

        public string? LocalizationOfClient { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name of client: {NameOfClient}, Localization: {LocalizationOfClient}";
        }
    }
}
