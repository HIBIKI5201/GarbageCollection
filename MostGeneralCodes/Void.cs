using System;

public struct Void : IEquatable<Void>, IDisposable
{
    public Void Null => VoidInstance;
    public Void Nil => VoidInstance;
    public Void None => VoidInstance;
    public Void Never => VoidInstance;
    public Void Empty => VoidInstance;
    public Void Hollow => VoidInstance;
    public Void Nihil => VoidInstance;

    private static readonly Void VoidInstance = new Void();

    public static Void operator +(Void v1, Void v2) => throw new NullReferenceException();

    public static Void operator -(Void v1, Void v2) => throw new NullReferenceException();

    public static Void operator *(Void v1, Void v2) => throw new NullReferenceException();

    public static Void operator /(Void v1, Void v2) => throw new NullReferenceException();

    public static Void operator %(Void v1, Void v2) => throw new NullReferenceException();

    public static bool operator ==(Void v1, Void v2) => throw new NullReferenceException();

    public static bool operator !=(Void v1, Void v2) => throw new NullReferenceException();

    public static bool operator >(Void v1, Void v2) => throw new NullReferenceException();

    public static bool operator <(Void v1, Void v2) => throw new NullReferenceException();

    public static bool operator >=(Void v1, Void v2) => throw new NullReferenceException();

    public static bool operator <=(Void v1, Void v2) => throw new NullReferenceException();

    public override bool Equals(object obj)
    {
        return obj is Void other && Equals(other);
    }

    public override int GetHashCode() => throw new NullReferenceException();

    public bool Equals(Void other)
    {
        throw new NullReferenceException();
    }

    public void Dispose()
    {
        throw new NullReferenceException();
    }
}