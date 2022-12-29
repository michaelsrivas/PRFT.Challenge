using System.Net;

namespace PRFT.Challenge.Application.Common.Errors;

internal class InvalidEmailException : Exception, IServiceException
{
    public HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

    public string ErrorMerrage => "User with given email does not exist.";
}
