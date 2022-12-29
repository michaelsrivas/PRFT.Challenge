using PRFT.Challenge.Application.Common.Interfaces.Persistence;
using PRFT.Challenge.Domain.ClientAggregate.Entities;

namespace PRFT.Challenge.Infrastructure.Persistence
{
    public class BranchRepository : IBranchRepository
    {
        private static readonly List<Branch> _branches = new();

        public void Add(Branch branch)
        {
            _branches.Add(branch);
        }
    }
}
