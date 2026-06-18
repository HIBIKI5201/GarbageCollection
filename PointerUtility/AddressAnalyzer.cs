using System.Runtime.CompilerServices;

public static class AddressAnalyzer
{
    public static unsafe bool IsPrime<T>(scoped in T value) where T : allows ref struct => IsPrime(Unsafe.AsPointer(ref Unsafe.AsRef(in value)));

    public static unsafe bool IsPrime(void* ptr)
    {
        nuint address = (nuint)ptr;

        if (address < 2) { return false; } // 1以下は素数ではない。
        if (address == 2) { return true; } // 2は素数。
        if ((address & 1) == 0) { return false; } // 1ビット目が0なら偶数。偶数は素数ではない。

        for (nuint i = 3; i * i <= address; i += 2)
        {
            if (address % i == 0) { return false; }
        }

        return true;
    }

    public static unsafe bool IsEven<T>(scoped in T value) where T : allows ref struct => IsEven(Unsafe.AsPointer(ref Unsafe.AsRef(in value)));
    
    public static unsafe bool IsEven(void* ptr)
    {
        nuint address = (nuint)ptr;

        return (address & 1) == 0; // 1ビット目が0なら偶数。
    }

    public static unsafe string AddressToString<T>(scoped in T value) where T : allows ref struct => AddressToString(Unsafe.AsPointer(ref Unsafe.AsRef(in value)));

    public static unsafe string AddressToString(void* ptr)
    {
        nuint address = (nuint)ptr;
        Console.WriteLine(address);
        int size = sizeof(nuint);
        Span<char> chars = stackalloc char[size];

        for (int i = 0; i < size; i++)
        {
            chars[i] = (char)((address >> (i * 8)) & 0xFF);
        }

        return new string(chars);
    }
}
