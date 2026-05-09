using LoginNexus.Models;

namespace LoginNexus.Services;

public class AuthService
{
    private readonly List<User> _users = new()
    {
        new User { Email = "professor@nexus.edu", Password = "123", Role = "Professor", Name = "Dr. Arnaldo" },
        new User { Email = "aluno@nexus.edu", Password = "123", Role = "Student", Name = "Estudante 01" }
    };

    public User? CurrentUser { get; private set; }

    public User? Authenticate(string email, string password)
    {
        var user = _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        if (user != null)
            CurrentUser = user;
        return user;
    }

    public void Logout()
    {
        CurrentUser = null;
    }
}