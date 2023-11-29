namespace CleanArchitecture.Application.Common;

public class Result
{
    public bool IsSuccess { get; init; }
    public bool IsFailure
        => !IsSuccess;

    public string Message { get; init; }

    public Result()
      => IsSuccess = true;

    public Result(string message)
    {
        IsSuccess = false;
        Message = message;
    }

    public static Result Failure(string msg)
         => new(msg);

    public static Result Success()
        => new();
}