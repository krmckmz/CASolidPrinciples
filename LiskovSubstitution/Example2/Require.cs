public static class Require
{
    public static void That(Func<bool> check)
    {
        if (!check())
            throw new ArgumentException("Invalid Argument");
    }
}