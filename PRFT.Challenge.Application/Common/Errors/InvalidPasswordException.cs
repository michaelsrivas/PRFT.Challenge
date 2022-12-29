using System.Net;

namespace PRFT.Challenge.Application.Common.Errors;

public class InvalidPasswordException : Exception, IServiceException
{
    public HttpStatusCode StatusCode => HttpStatusCode.Unauthorized;

    public string ErrorMerrage => "Invalid password.";
}
