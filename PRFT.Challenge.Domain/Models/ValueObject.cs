namespace PRFT.Challenge.Domain.Models;

public abstract class ValueObject : IEquatable<ValueObject>
{
    public abstract IEnumerable<object> GetEqualityComponents();

    public override bool Equals(object? obj)
    {
        if(obj is null || obj.GetType() != GetType())
        {
            return false;
        }

        var valueObject = (ValueObject)obj;
        return GetEqualityComponents()
            .SequenceEqual(valueObject.GetEqualityComponents());
    }

    public static bool operator ==(ValueObject left, ValueObject right) 
    {
        return Equals(left, right);
    }

    public static bool operator !=(ValueObject left, ValueObject right)
    {
        return !Equals(left, right);
    }

    public override int GetHashCode()
    {
        return GetEqualityComponents()
            .Select(x => x?.GetHashCode() ?? 0)
            .Aggregate((x,y) => x ^ y);
    }

    public bool Equals(ValueObject? other)
    {
        return Equals((object?)other);
    }
}

public class Client : ValueObject
{
    public string ClientType { get; set; }
    public string FullName { get; set; }
    public string Id { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string PhoneNumber { get; set; }
    public string MobileNumber { get; set; }
    public string Email { get; set; }

    public Client(string clientType,
        string fullName,
        string id,
        string address,
        string city,
        string country,
        string phoneNumber,
        string mobileNumber,
        string email)
    {
        ClientType = clientType;
        FullName = fullName;
        Id = id;
        Address = address;
        City = city;
        Country = country;
        PhoneNumber = phoneNumber;
        MobileNumber = mobileNumber;
        Email = email;
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return ClientType;
        yield return FullName;
        yield return Id;
        yield return Address;
        yield return City;
        yield return Country;
        yield return PhoneNumber;
        yield return MobileNumber;
        yield return Email;
    }
}
