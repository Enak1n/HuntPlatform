using HuntPlatform.Domain.Aggregates.Vacancies.Exceptions;

namespace HuntPlatform.Domain.Aggregates.Vacancies;

public sealed class WorkFormat : EnumBase<string>
{
    private WorkFormat(string id) : base(id)
    {
    }

    public static WorkFormat InOffice => new("Офис");

    public static WorkFormat Hybrid => new("Гибрид");

    public static WorkFormat Distance => new("Удаленно");

    public static WorkFormat Create(string id) => id switch
    {
        "Офис" => InOffice,
        "Гибрид" => Hybrid,
        "Удаленно" => Distance,
        _ => throw new InvalidWorkFormatException(id)
    };
}

