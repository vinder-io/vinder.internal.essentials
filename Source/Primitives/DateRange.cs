namespace Vinder.Internal.Essentials.Primitives;

public sealed record DateRange(DateOnly Start, DateOnly End) : IValueObject<DateRange>
{
    public DateOnly Start { get; init; } = Start;
    public DateOnly End { get; init; } = End;

    public int DurationInDays => End.DayNumber - Start.DayNumber + 1;

    public bool Contains(DateOnly date) =>
        date >= Start && date <= End;

    public bool Overlaps(DateRange other) =>
        Start <= other.End && End >= other.Start;
}
