static class LogLine
{
    public static string Message(string logLine)
    {
        return $"[{LogLevel}]: {logLine}";
    }

    public static string LogLevel(string logLine)
    {
        return logLine.ToUpper();
    }

    public static string Reformat(string logLine)
    {
        return $"[{LogLevel}]: {Message}";
    }
}
