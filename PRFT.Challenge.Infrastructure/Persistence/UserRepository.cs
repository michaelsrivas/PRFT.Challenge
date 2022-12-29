using PRFT.Challenge.Application.Common.Interfaces.Persistence;
using PRFT.Challenge.Domain.Entities;

namespace PRFT.Challenge.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();
    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GerUserByEmail(string email)
    {
        return _users.SingleOrDefault(u => u.Email == email);
    }
}
