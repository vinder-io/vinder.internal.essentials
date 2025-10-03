namespace Vinder.Internal.Essentials.Contracts;

public interface IValueObject<TObject> : IEquatable<TObject> where TObject :
    IValueObject<TObject>;