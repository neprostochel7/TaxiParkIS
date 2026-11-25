namespace TaxiParkIS.Models
{
    public class User
    {
        public string Login { get; set; } = "";
        public string Password { get; set; } = "";
        public string Role { get; set; } = "Пользователь"; // Администратор | Пользователь
        public bool IsBlocked { get; set; } = false;

        public override string ToString() => $"{Login} ({Role})";
    }
}