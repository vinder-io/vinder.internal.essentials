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

    public static string FromMask(string mask)
    {
        Span<char> result = stackalloc char[mask.Length];
        Span<byte> randomBytes = stackalloc byte[mask.Length];

        _randomNumberGenerator.GetBytes(randomBytes);

        for (int index = 0; index < mask.Length; index++)
        {
            char character = mask[index];
            byte @byte = randomBytes[index];

            result[index] = character switch
            {
                'D' => (char)('0' + (@byte % 10)), // 0-9
                'A' => (char)('A' + (@byte % 26)), // A-Z
                'a' => (char)('a' + (@byte % 26)), // a-z
                'X' => _alphabet[@byte % _alphabet.Length], // Alphanumeric
                _ => character // Literal
            };
        }

        return new string(result);
    }

    public static Code FromMask(string mask, TimeSpan validity)
    {
        Span<char> result = stackalloc char[mask.Length];
        Span<byte> randomBytes = stackalloc byte[mask.Length];

        _randomNumberGenerator.GetBytes(randomBytes);

        for (int index = 0; index < mask.Length; index++)
        {
            char character = mask[index];
            byte @byte = randomBytes[index];

            result[index] = character switch
            {
                'D' => (char)('0' + (@byte % 10)), // 0-9
                'A' => (char)('A' + (@byte % 26)), // A-Z
                'a' => (char)('a' + (@byte % 26)), // a-z
                'X' => _alphabet[@byte % _alphabet.Length], // alphanumeric
                _ => character
            };
        }

        return new Code(new(result), validity);
    }

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