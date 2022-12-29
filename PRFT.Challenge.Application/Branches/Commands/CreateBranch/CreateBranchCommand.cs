using ErrorOr;
using MediatR;
using PRFT.Challenge.Application.Common.SharedEntities;
using PRFT.Challenge.Domain.ClientAggregate.Entities;

namespace PRFT.Challenge.Application.Branches.Commands.CreateBranch;

public record CreateBranchCommand(
    string ClientId,
    string Code,
    string Name,
    string VendorCode,
    int CreditLimit,
    ContactInfoCommand ContactInfo) : IRequest<ErrorOr<Branch>>;
