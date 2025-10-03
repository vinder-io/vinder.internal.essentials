namespace Vinder.Internal.Essentials.Utilities;

public static class Identifier
{
    private const string _alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private static readonly RandomNumberGenerator _randomNumberGenerator = RandomNumberGenerator.Create();

    public static string Generate<TResource>(int randomPartLength = 25)
    {
        var prefix = typeof(TResource).Name.ToLowerInvariant();

        return $"{prefix}_{RandomString(randomPartLength)}";
    }

    public static string Generate(string prefix, int randomPartLength = 25)
        => $"{prefix.ToLowerInvariant()}_{RandomString(randomPartLength)}";

    private static string RandomString(int length)
    {
        Span<byte> bytes = stackalloc byte[length];
        Span<char> chars = stackalloc char[length];

        _randomNumberGenerator.GetBytes(bytes);

        for (int index = 0; index < length; index++)
        {
            chars[index] = _alphabet[bytes[index] % _alphabet.Length];
        }

        return new string(chars);
    }
}