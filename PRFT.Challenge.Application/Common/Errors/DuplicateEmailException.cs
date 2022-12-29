using System.Net;

namespace PRFT.Challenge.Application.Common.Errors;

public class DuplicateEmailException : Exception, IServiceException
{
    public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

    public string ErrorMerrage => "Email already exists.";
}
