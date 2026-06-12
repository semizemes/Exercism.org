static class LogLine
{
    public static string Message(string logLine)
    {
        string[] words = logLine.Split(' ');
        return string.Join(" ", words.Skip(2));
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
