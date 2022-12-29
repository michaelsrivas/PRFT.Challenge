using ErrorOr;
using MediatR;
using PRFT.Challenge.Application.Common.Interfaces.Persistence;
using PRFT.Challenge.Domain.ClientAggregate;
using PRFT.Challenge.Domain.ClientAggregate.Common;
using PRFT.Challenge.Domain.ClientAggregate.Entities;

namespace PRFT.Challenge.Application.Clients.Commands.CreateClient;

public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, ErrorOr<Client>>
{
    private readonly IClientRepository _clientRepository;

    public CreateClientCommandHandler(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<ErrorOr<Client>> Handle(CreateClientCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var client = Client.Create(
            request.ClientType,
            request.FullName,
            request.DocumentId,
            new ContactInfo
            {
                Address = request.ContactInfo.Address,
                City = request.ContactInfo.City,
                Country = request.ContactInfo.Country,
                Email = request.ContactInfo.Email,
                MobileNumber = request.ContactInfo.MobileNumber,
                PhoneNumber = request.ContactInfo.PhoneNumber,
            },
            request.Branches.ConvertAll(branch => Branch.Create(
                branch.Code,
                branch.Name,
                branch.VendorCode,
                branch.CreditLimit,
                new ContactInfo
                {
                    Address = branch.ContactInfo.Address,
                    City = branch.ContactInfo.City,
                    Country = branch.ContactInfo.Country,
                    Email = branch.ContactInfo.Email,
                    MobileNumber = branch.ContactInfo.MobileNumber,
                    PhoneNumber = branch.ContactInfo.PhoneNumber,
                })));

        _clientRepository.Add(client);

        return client;
    }
}
