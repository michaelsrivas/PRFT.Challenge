using ErrorOr;
using MediatR;
using PRFT.Challenge.Application.Authentication.Common;

namespace PRFT.Challenge.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;
