using PRFT.Challenge.Domain.Entities;

namespace PRFT.Challenge.Application.Common.Interfaces.Persistence
{
    public interface IUserRepository
    {
        User? GerUserByEmail(string email);
        void Add(User user);
    }
}
