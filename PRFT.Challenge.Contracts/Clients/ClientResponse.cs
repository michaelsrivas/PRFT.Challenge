using PRFT.Challenge.Contracts.Common;

namespace PRFT.Challenge.Contracts.Clients;

public record ClientResponse(
    Guid Id,
    string ClientType,
    string FullName,
    string DocumentId,
    ContactInfo ContactInfo,
    List<Branch> Branches);
