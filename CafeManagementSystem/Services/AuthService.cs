using CafeManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace CafeManagementSystem.Services;

public class AuthService
{
    private readonly List<User> _users = new()
    {
        new User { Username = "admin", Password = "admin123", Role = UserRole.Admin, DisplayName = "Алексей Петров" },
        new User { Username = "waiter", Password = "waiter123", Role = UserRole.Waiter, DisplayName = "Мария Иванова" },
        new User { Username = "cook", Password = "cook123", Role = UserRole.Cook, DisplayName = "Иван Сидоров" }
    };

    public User? Authenticate(string username, string password)
    {
        return _users.FirstOrDefault(u => 
            u.Username == username && u.Password == password);
    }
}