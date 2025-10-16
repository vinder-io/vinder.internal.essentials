#pragma warning disable SYSLIB1045

// we disabled the SYSLIB1045 warning because we chose to use the Regex class directly
// with RegexOptions.Compiled instead of using [GeneratedRegex], even though .NET recommends it.

namespace Vinder.Internal.Essentials.Utilities;

public static class ExpressionPatterns
{
    /// <summary>
    /// matches a valid email address
    /// </summary>
    public static readonly Regex Email = new(
        pattern: @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
        options: RegexOptions.Compiled | RegexOptions.IgnoreCase
    );

    /// <summary>
    /// matches a brazilian phone number (with or without country code)
    /// </summary>
    public static readonly Regex BrazilianPhone = new(
        pattern: @"^(\+55\s?)?(\(?\d{2}\)?\s?)?\d{4,5}-?\d{4}$",
        options: RegexOptions.Compiled
    );

    /// <summary>
    /// matches a brazilian cpf (with or without formatting)
    /// </summary>
    public static readonly Regex Cpf = new(
        pattern: @"^\d{3}\.?\d{3}\.?\d{3}-?\d{2}$",
        options: RegexOptions.Compiled
    );

    /// <summary>
    /// matches a brazilian cnpj (with or without formatting)
    /// </summary>
    public static readonly Regex Cnpj = new(
        pattern: @"^\d{2}\.?\d{3}\.?\d{3}/?\d{4}-?\d{2}$",
        options: RegexOptions.Compiled
    );

    /// <summary>
    /// matches any non-numeric character, useful to sanitize cpfs, cnpjs and phone numbers
    /// </summary>
    public static readonly Regex NumbersOnly = new(
        pattern: @"\D",
        options: RegexOptions.Compiled
    );

    /// <summary>
    /// valid url pattern (http/https, with optional www, query strings, fragments)
    /// </summary>
    public static readonly Regex Url = new(
        pattern: @"^(https?:\/\/)?([\w\-]+(\.[\w\-]+)+)([\w\-,@?^=%&:/~+#]*[\w\-,@?^=%&/~+#])?$",
        options: RegexOptions.Compiled | RegexOptions.IgnoreCase
    );

    /// <summary>
    /// matches brazilian postal code (cep) with or without hyphen
    /// </summary>
    public static readonly Regex Cep = new(
        pattern: @"^\d{5}-?\d{3}$",
        options: RegexOptions.Compiled
    );

    /// <summary>
    /// matches credit card number (16 digits, optional spaces or dashes)
    /// </summary>
    public static readonly Regex CreditCard = new(
        pattern: @"^(\d{4}[- ]?){3}\d{4}$",
        options: RegexOptions.Compiled
    );

    /// <summary>
    /// matches a valid PIX key (cpf, cnpj, email, phone or random key)
    /// </summary>
    public static readonly Regex PixKey = new(
        pattern: @"^([0-9]{11}|[0-9]{14}|[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}|[0-9a-fA-F]{32}|(\+55)?\d{10,11})$",
        options: RegexOptions.Compiled | RegexOptions.IgnoreCase
    );

    /// <summary>
    /// matches a valid brazilian currency format (with optional "R$" and thousands separator)
    /// </summary>
    public static readonly Regex Money = new(
        pattern: @"^R?\$?\s?\d{1,3}(\.\d{3})*,\d{2}$",
        options: RegexOptions.Compiled
    );

    /// <summary>
    /// matches a full name containing at least two words with only letters and spaces (including accented characters)
    /// </summary>
    public static readonly Regex FullName = new(
        pattern: @"^[A-Za-zÀ-ÖØ-öø-ÿ]+(\s[A-Za-zÀ-ÖØ-öø-ÿ]+)+$",
        options: RegexOptions.Compiled
    );
}