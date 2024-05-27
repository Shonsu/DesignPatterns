namespace Observer;

public static class Extensions
{
    public static TEnum ToEnum<TEnum>(this string value, TEnum defaultValue)
        where TEnum : struct
    {
        if (string.IsNullOrEmpty(value))
        {
            return defaultValue;
        }

        TEnum result;
        return Enum.TryParse<TEnum>(value, true, out result) ? result : defaultValue;
    }
}
