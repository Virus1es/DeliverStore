using DeliverStore.Domain.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace DeliverStore.Web.Extensions;

public static class ResponseExtensions
{
    public static ActionResult ToErrorResponse(this Error error)
    {
        var statusCode = error.Type switch
        {
            ErrorType.Validation => StatusCodes.Status400BadRequest,
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            ErrorType.Failture => StatusCodes.Status500InternalServerError,
            _ => StatusCodes.Status500InternalServerError
        };

        return new ObjectResult(error)
        {
            StatusCode = statusCode
        };
    }
}
