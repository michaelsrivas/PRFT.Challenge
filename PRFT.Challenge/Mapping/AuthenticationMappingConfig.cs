using Mapster;
using PRFT.Challenge.Application.Authentication.Commands.Register;
using PRFT.Challenge.Application.Authentication.Common;
using PRFT.Challenge.Application.Authentication.Queries.Login;
using PRFT.Challenge.Contracts.Authentication;

namespace PRFT.Challenge.Api.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();
        config.NewConfig<LoginRequest, LoginQuery>();
        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}
