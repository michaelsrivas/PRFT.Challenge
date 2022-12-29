using PRFT.Challenge.Domain.Entities;

namespace PRFT.Challenge.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
