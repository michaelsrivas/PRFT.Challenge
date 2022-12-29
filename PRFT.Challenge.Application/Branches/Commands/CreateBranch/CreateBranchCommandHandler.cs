using ErrorOr;
using MediatR;
using PRFT.Challenge.Application.Common.Interfaces.Persistence;
using PRFT.Challenge.Domain.ClientAggregate.Common;
using PRFT.Challenge.Domain.ClientAggregate.Entities;

namespace PRFT.Challenge.Application.Branches.Commands.CreateBranch;

internal class CreateBranchCommandHandler : IRequestHandler<CreateBranchCommand, ErrorOr<Branch>>
{
    private readonly IBranchRepository _branchRespository;

    public CreateBranchCommandHandler(IBranchRepository branchRespository)
    {
        _branchRespository = branchRespository;
    }

    public async Task<ErrorOr<Branch>> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var branch = Branch.Create(
            request.Code,
            request.Name,
            request.VendorCode,
            request.CreditLimit,
            new ContactInfo
            {
                Address = request.ContactInfo.Address,
                City = request.ContactInfo.City,
                Country = request.ContactInfo.Country,
                Email = request.ContactInfo.Email,
                MobileNumber = request.ContactInfo.MobileNumber,
                PhoneNumber = request.ContactInfo.PhoneNumber,
            });

        _branchRespository.Add(branch);

        return branch;
    }
}
