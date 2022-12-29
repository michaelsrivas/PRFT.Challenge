using Mapster;
using PRFT.Challenge.Application.Clients.Commands.CreateClient;
using PRFT.Challenge.Contracts.Branches;
using PRFT.Challenge.Contracts.Clients;
using PRFT.Challenge.Domain.ClientAggregate;
using Branch = PRFT.Challenge.Domain.ClientAggregate.Entities.Branch;

namespace PRFT.Challenge.Api.Common.Mapping;

public class ClientMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CreateClientRequest, CreateClientCommand>();

        config.NewConfig<Client, ClientResponse>()
            .Map(dest => dest.Id, src => src.Id.Value);
        
        config.NewConfig<Branch, BranchResponse>()
            .Map(dest => dest.Id, src => src.Id.Value);

    }
}
