namespace HuntPlatform.Domain.Aggregates.Vacancies.Exceptions;

public sealed class InvalidWorkFormatException : Exception
{
    public InvalidWorkFormatException(string message) : base(message)
    {
        
    }
}
