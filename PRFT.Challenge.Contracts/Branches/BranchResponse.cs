using PRFT.Challenge.Contracts.Common;

namespace PRFT.Challenge.Contracts.Branches;

public record BranchResponse(
    Guid Id,
    string Code,
    string Name,
    string VendorCode,
    int CreditLimit,
    ContactInfo ContactInfo);
