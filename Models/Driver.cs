namespace TaxiParkIS.Models
{
    public class Driver
    {
        public string FullName { get; set; } = "";
        public string LicenseNumber { get; set; } = "";
        public int Experience { get; set; }
        public string Phone { get; set; } = "";
        public string Status { get; set; } = "Свободен";
    }
}