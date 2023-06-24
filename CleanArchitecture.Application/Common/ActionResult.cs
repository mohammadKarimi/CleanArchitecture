using System.Reflection.Metadata;

namespace CleanArchitecture.Application.Common;

public class ActionResult
{
    public bool IsSuccess { get; init; }
    public string Message { get; init; }

    public ActionResult(string message)
    {
        IsSuccess = false;
        Message = message;
    }

    public ActionResult()
    {
        IsSuccess = true;
    }

    public static ActionResult Failure(string msg)
         => new(msg);

    public static ActionResult Success()
        => new();
}