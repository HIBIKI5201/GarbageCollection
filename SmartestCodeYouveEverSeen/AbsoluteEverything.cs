using System;

class AbsoluteEverything
{
    static void Main()
    {
        // 数字（0~9）を一切使わずに2を表現する
        
        var value = AbsoluteTwo();
        if (IsThisAbsoluteTwo(value))
        {
            Console.WriteLine(value);
        }
    }
    
    public static int AbsoluteZero()
    {
        return default(int);
    }

    public static int AbsoluteOne()
    {
        var value = int.MaxValue / int.MaxValue;
        return value;
    }

    public static void IncrementOne(ref int a)
    {
        var value = a;
        var result = value + AbsoluteOne();
        a = result;
    }

    public static bool AbsoluteTrue()
    {
        bool value;
        value = AbsoluteOne() == AbsoluteOne();
        return value;
    }

    public static bool AbsoluteFalse()
    {
        bool value;
        value = AbsoluteOne() == AbsoluteTwo();
        return value;
    }

    public static bool IsTrue(bool value)
    {
        if (value == AbsoluteTrue())
        {
            return value;
        }
        if (value == AbsoluteFalse())
        {
            return value;
        }

        throw new ArgumentException();
    }
    
    public static bool IsThisAbsoluteOne(int value)
    {
        if (IsTrue(value == AbsoluteOne()))
        {
            return AbsoluteTrue();
        }
        
        throw new ArgumentException();
    }

    public static void VerySafeCode()
    {
        throw new();
    }
    
    public static bool IsThisAbsoluteTwo(int value)
    {
        if (IsTrue(value == AbsoluteTwo()) == AbsoluteTrue())
        {
            return AbsoluteTrue();
        }
        
        throw new ArgumentException();
    }

    public static int ValuePlusValue(int value, int newValue)
    {
        var result = value;
        var newResult = result + newValue;
        result = newResult;
        return result;
    }

    public static int AbsoluteTwo()
    {
        var value = AbsoluteOne();
        IncrementOne(ref value);
        return value;
    }
}