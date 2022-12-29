using Mapster;
using PRFT.Challenge.Application.Branches.Commands.CreateBranch;
using PRFT.Challenge.Contracts.Branches;
using PRFT.Challenge.Domain.ClientAggregate.Entities;

namespace PRFT.Challenge.Api.Common.Mapping;

public class BranchMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<(CreateBranchRequest request, string clientId), CreateBranchCommand>()
            .Map(dest => dest.ClientId, src => src.clientId)
            .Map(dest => dest, src => src.request);

        config.NewConfig<Branch, BranchResponse>()
            .Map(dest => dest.Id, src => src.Id.Value);
    }
}
