namespace Vinder.Internal.Essentials.Primitives;

public sealed record Code(string Identifier, DateTime Expires) : IValueObject<Code>
{
    public bool HasExpired => DateTime.UtcNow > Expires;
    public Code(string identifier, TimeSpan validity) : this(identifier, DateTime.UtcNow.Add(validity)) {   }
}