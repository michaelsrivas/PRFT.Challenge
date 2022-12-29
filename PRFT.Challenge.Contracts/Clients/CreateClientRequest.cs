using PRFT.Challenge.Contracts.Common;

namespace PRFT.Challenge.Contracts.Clients;

public record CreateClientRequest(
    string ClientType,
    string FullName,
    string DocumentId,
    ContactInfo ContactInfo,
    List<Branch> Branches
    );

public record Branch(        
    string Code,
    string Name,
    string VendorCode,
    int CreditLimit,
   ContactInfo ContactInfo);
