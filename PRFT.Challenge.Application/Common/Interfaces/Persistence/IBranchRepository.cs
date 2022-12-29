using PRFT.Challenge.Domain.ClientAggregate.Entities;

namespace PRFT.Challenge.Application.Common.Interfaces.Persistence;

public interface IBranchRepository
{
    void Add(Branch branch);
}
