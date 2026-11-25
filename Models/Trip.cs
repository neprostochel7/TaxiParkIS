namespace TaxiParkIS.Models
{
    public class Trip
    {
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string AddressStart { get; set; } = "";
        public string AddressEnd { get; set; } = "";
        public string ClientName { get; set; } = "";
        public string DriverName { get; set; } = "";
        public decimal Cost { get; set; }
        public string Status { get; set; } = "Ожидает";
    }
}