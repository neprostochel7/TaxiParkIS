namespace TaxiParkIS.Models
{
    public static class UserRepository
    {
        public static readonly List<User> Users = new()
        {
            new User { Login = "admin",  Password = "admin123", Role = "Администратор" },
            new User { Login = "user1",  Password = "pass1",    Role = "Пользователь"  },
            new User { Login = "user2",  Password = "pass2",    Role = "Пользователь"  }
        };

        public static User? Find(string login, string password) =>
            Users.FirstOrDefault(u => u.Login == login && u.Password == password);

        public static bool LoginExists(string login) =>
            Users.Any(u => u.Login == login);
    }
}