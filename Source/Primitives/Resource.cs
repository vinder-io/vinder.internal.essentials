namespace Vinder.Internal.Essentials.Primitives;

public sealed record Resource(string Identifier, string DisplayName) : IValueObject<Resource>
{
    public string Identifier { get; init; } = Identifier;
    public string DisplayName { get; init; } = DisplayName;

    public static Resource From(string identifier, string displayName) =>
        new(identifier, displayName);
}