namespace Vinder.Internal.Essentials.Primitives;

public sealed record Tenant(string Identifier, string Name) : IValueObject<Tenant>
{
    public string Identifier { get; init; } = Identifier;
    public string Name { get; init; } = Name;
}