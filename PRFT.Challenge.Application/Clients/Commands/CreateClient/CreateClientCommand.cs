using ErrorOr;
using MediatR;
using PRFT.Challenge.Application.Common.SharedEntities;
using PRFT.Challenge.Domain.ClientAggregate;

namespace PRFT.Challenge.Application.Clients.Commands.CreateClient;

public record CreateClientCommand(
    string ClientType,
    string FullName,
    string DocumentId,
    ContactInfoCommand ContactInfo,
    List<BranchCommand> Branches) : IRequest<ErrorOr<Client>>;

public record BranchCommand(
    string Code,
    string Name,
    string VendorCode,
    int CreditLimit,
   ContactInfoCommand ContactInfo);
