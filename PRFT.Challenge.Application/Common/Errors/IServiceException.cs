using System.Net;

namespace PRFT.Challenge.Application.Common.Errors;

public interface IServiceException
{
    public HttpStatusCode StatusCode { get; }
    public string ErrorMerrage { get; }
}
