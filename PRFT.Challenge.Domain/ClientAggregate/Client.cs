using PRFT.Challenge.Domain.ClientAggregate.Entities;
using PRFT.Challenge.Domain.ClientAggregate.Common;
using PRFT.Challenge.Domain.ClientAggregate.ValueObjects;
using PRFT.Challenge.Domain.Models;

namespace PRFT.Challenge.Domain.ClientAggregate;

public sealed class Client : AggregateRoot<ClientId>
{
    private readonly List<Branch> _branches = new();
    public string ClientType { get; }
    public string FullName { get; }
    public string DocumentId { get; }
    public ContactInfo ContactInfo { get; }

    public IReadOnlyList<Branch> Branches => _branches.AsReadOnly();

    public Client(
        ClientId clientId,
        string clientType,
        string fullName,
        string documentId,
        ContactInfo contactInfo,
        List<Branch> branches)
        : base(clientId)
    {     
        ClientType = clientType;
        FullName = fullName;
        DocumentId = documentId;
        ContactInfo = contactInfo;
        _branches = branches;
    }

    public static Client Create(
        string clientType,
        string fullName,
        string documentId,
        ContactInfo contactInfo,
        List<Branch>? branches)
    {
        return new(
            ClientId.CreateUnique(),
            clientType,
            fullName,
            documentId,
            contactInfo,
            branches ?? new());
    }
}
