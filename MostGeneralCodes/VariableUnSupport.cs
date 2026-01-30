using System.Reflection;

public class VariableUnSupport
{
    public static Void AssignmentValue<T>(ref T container, T value) where T : struct
    {
        container = value;
        return new Void();
    }

    public static Void AssignmentValue<T>(T container, T value) where T : class
    {
        var fields = typeof(T).GetFields(
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance);
        foreach (var fieldInfo in fields)
        {
            fieldInfo.SetValue(container, fieldInfo.GetValue(value));
        }

        return new Void();
    }
}