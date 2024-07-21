
namespace PMApp.Entities
{
    //klasa opisująca projekt/zlecenie do wykonania od klienta
    public class Project : EntityBase 
    {
        public string? NameOfProject { get; set; }

        public int PriceOfProject { get; set; }

        public float TargetProfitMarginInPLN { get; set; }

        //Do zdefiniowania zespół

        public override string ToString()
        {
            return $"Id: {Id}, Name of project: {NameOfProject}, Price of the Project: {PriceOfProject},  " +
                $"Target Profit Margin in PLN: {TargetProfitMarginInPLN}";
        }
    }
}
