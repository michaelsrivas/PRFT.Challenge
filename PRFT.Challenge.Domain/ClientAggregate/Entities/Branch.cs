using PRFT.Challenge.Domain.ClientAggregate.Common;
using PRFT.Challenge.Domain.ClientAggregate.ValueObjects;
using PRFT.Challenge.Domain.Models;

namespace PRFT.Challenge.Domain.ClientAggregate.Entities;

public sealed class Branch : Entity<BranchId>
{
    public string Code { get; }
    public string Name { get; }
    public string VendorCode { get; }
    public int CreditLimit { get; }
    public ContactInfo ContactInfo { get; }

    private Branch(
        BranchId branchId,
        string code,
        string name,
        string vendorCode,
        int creditLimit,
       ContactInfo contactInfo)
        : base(branchId)
    {
        Code = code;
        Name = name;
        VendorCode = vendorCode;
        CreditLimit = creditLimit;
        ContactInfo = contactInfo;
    }

    public static Branch Create(
        string code,
        string name,
        string vendorCode,
        int creditLimit,
        ContactInfo contactInfo)
    {
        return new(
            BranchId.CreateUnique(),
            code,
            name,
            vendorCode,
            creditLimit,
            contactInfo);
    }
}
