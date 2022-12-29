using PRFT.Challenge.Domain.ClientAggregate;

namespace PRFT.Challenge.Application.Common.Interfaces.Persistence;

public interface IClientRepository
{
    void Add(Client client);
}
