namespace PRFT.Challenge.Application.Common.SharedEntities;

public record ContactInfoCommand(
    string Address,
    string City,
    string Country,
    string PhoneNumber,
    string MobileNumber,
    string Email);
