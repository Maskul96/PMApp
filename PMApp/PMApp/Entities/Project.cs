
namespace PMApp.Entities
{
    //klasa opisująca projekt/zlecenie do wykonania od klienta
    public class Project : EntityBase 
    {
        public string? NameOfProject { get; set; }

        public int PriceOfProject { get; set; }

        public float TargetProfitMarginInPLN { get; set; }

        public Manager? ProjectManager { get; set; }

        public Employee? Programmer { get; set; }

        public Employee? ElectricalDesigner { get; set; }

        public Employee? MechanicalDesigner { get; set; }

        public Employee? SafetyDesigner { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name of project: {NameOfProject}, Price of the Project: {PriceOfProject},  " +
                $"Target Profit Margin in PLN: {TargetProfitMarginInPLN}, PM: {ProjectManager}";
        }
    }
}
