namespace HuntPlatform.Domain.Aggregates;

public abstract class EnumBase<T>
{
    public T Id { get; }
    
    protected EnumBase(T id)
    {
        Id = id;
    }

    public override string ToString() => Id!.ToString()!;

    private bool Equals(EnumBase<T> other) => EqualityComparer<T>.Default.Equals(Id, other.Id);

    public override bool Equals(object? obj) => obj is EnumBase<T> other && Equals(other);

    public override int GetHashCode() => EqualityComparer<T>.Default.GetHashCode(Id!);

    public static bool operator ==(EnumBase<T>? left, EnumBase<T>? right) => Equals(left, right);

    public static bool operator !=(EnumBase<T>? left, EnumBase<T>? right) => !Equals(left, right);
}

