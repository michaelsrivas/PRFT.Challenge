using ErrorOr;

namespace PRFT.Challenge.Domain.Common.Errors;

public static partial class Errors
{
    public static class Authentication
    {
        public static Error InvalidCredentials => Error.Validation(
           code: "Auth.InvalidCred",
           description: "Invalid credentials.");
    }
}
