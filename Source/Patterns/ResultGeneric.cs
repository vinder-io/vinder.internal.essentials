namespace Vinder.Internal.Essentials.Patterns;

public class Result<TData>
{
    public bool IsSuccess { get; private set; }
    public bool IsFailure => !IsSuccess;

    public Error Error { get; private set; }
    public TData? Data { get; private set; }

    protected Result(bool isSuccess, TData? data, Error error)
    {
        IsSuccess = isSuccess;
        Error = error;
        Data = data;
    }

    public static Result<TData> Success(TData data) =>
        new(true, data, Error.None);

    public static Result<TData> Failure(Error error) =>
        new(false, default, error);
}
