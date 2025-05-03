namespace HuntPlatform.Domain.Aggregates.Vacancies.Exceptions;

public sealed class VallidationVacancyException : Exception
{
    public VallidationVacancyException(string message) : base(message)
    {
        
    }
}

