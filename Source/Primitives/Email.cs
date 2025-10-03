namespace Vinder.Internal.Essentials.Primitives;

public sealed record Email(string Address) : IValueObject<Email>
{
    public string Address { get; init; } = Address.Trim().ToLowerInvariant();
}
