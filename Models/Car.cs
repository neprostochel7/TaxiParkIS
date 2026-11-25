namespace TaxiParkIS.Models
{
    public class Car
    {
        public string Brand { get; set; } = "";
        public string Model { get; set; } = "";
        public string LicensePlate { get; set; } = "";
        public int Year { get; set; }
        public string Status { get; set; } = "Исправен";
    }
}