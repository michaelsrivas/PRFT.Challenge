using PRFT.Challenge.Domain.Entities;

namespace PRFT.Challenge.Application.Authentication.Common;

public record AuthenticationResult(User User, string Token);
