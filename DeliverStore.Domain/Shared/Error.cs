namespace DeliverStore.Domain.Shared;

public record Error
{
    public string Code { get; }
    public string Message { get; }
    public ErrorType Type { get; }


    private Error(string code, string message, ErrorType errorType) {
        Code = code;
        Message = message;
        Type = errorType;
    }

    public static Error Validation(string code, string message) =>
        new(code, message, ErrorType.Validation);

    public static Error NotFound(string code, string message) =>
        new(code, message, ErrorType.NotFound);

    public static Error Failture(string code, string message) =>
        new(code, message, ErrorType.Failture);

    public static Error Conflict(string code, string message) =>
        new(code, message, ErrorType.Conflict);
}

public enum ErrorType
{
    Validation,
    NotFound,
    Failture,
    Conflict
}