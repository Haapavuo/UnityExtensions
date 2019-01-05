using System;

public static class EnumExtensions
{
    public static Enum InvertFlag(this Enum e, Enum flag)
    {
        var eval = Convert.ToInt32(e);
        var flagval = Convert.ToInt32(flag);

        if (e.HasFlag(flag))
        {
            return (Enum)Enum.ToObject(e.GetType(), eval - flagval);
        }
        else
        {
            return (Enum)Enum.ToObject(e.GetType(), eval + flagval);
        }
    }
}
