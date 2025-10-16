namespace Vinder.Internal.Essentials.Extensions;

public static class StringExtensions
{
    public static decimal ToDecimalOrZero(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return 0m;
        }

        var normalized = value.Trim()
            .Replace(".", "")
            .Replace(",", ".");

        var parsed = decimal.TryParse(normalized,
            style: NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign,
            provider: CultureInfo.InvariantCulture,

            /* out parsed value: holds the resulting decimal if parsing succeeds */
            result: out var result
        );

        return parsed ? result : 0m;
    }

    public static string SanitizeNumbers(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        return ExpressionPatterns.NumbersOnly.Replace(value, string.Empty);
    }

    public static bool ToBoolean(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        var trimmed = value.Trim()
            .ToLowerInvariant()
            .RemoveAccents();

        if (trimmed == "true" || trimmed == "1" || trimmed == "sim")
        {
            return true;
        }

        if (trimmed == "false" || trimmed == "0" || trimmed == "nao")
        {
            return false;
        }

        return false;
    }

    public static string RemoveAccents(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        var normalized = value.Normalize(NormalizationForm.FormD);
        var stringBuilder = new StringBuilder();

        foreach (var character in normalized)
        {
            if (CharUnicodeInfo.GetUnicodeCategory(character) != UnicodeCategory.NonSpacingMark)
            {
                stringBuilder.Append(character);
            }
        }

        return stringBuilder.ToString()
            .Normalize(NormalizationForm.FormC);
    }

    public static string OrFallback(this string value, string defaultValue = "N/A")
    {
        return string.IsNullOrWhiteSpace(value)
            ? defaultValue
            : value;
    }

    public static string OrNotSpecified(this string value) =>
        value.OrFallback("NÃO ESPECIFICADO");

    public static string OrNotInformed(this string value) =>
        value.OrFallback("NÃO INFORMADO");
}