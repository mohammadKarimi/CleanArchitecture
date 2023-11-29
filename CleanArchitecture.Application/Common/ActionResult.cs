namespace CleanArchitecture.Application.Common;

public class ActionResult
{
    public bool IsSuccess { get; init; }
    public bool IsFailure
        => !IsSuccess;

    public string Message { get; init; }

    public ActionResult()
      => IsSuccess = true;

    public ActionResult(string message)
    {
        IsSuccess = false;
        Message = message;
    }

    public static ActionResult Failure(string msg)
         => new(msg);

    public static ActionResult Success()
        => new();
}