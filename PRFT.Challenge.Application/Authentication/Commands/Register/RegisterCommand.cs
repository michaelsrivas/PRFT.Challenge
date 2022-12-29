using ErrorOr;
using MediatR;
using PRFT.Challenge.Application.Authentication.Common;

namespace PRFT.Challenge.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;
