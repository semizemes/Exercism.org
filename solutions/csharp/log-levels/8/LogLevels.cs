static class LogLine
{
    public static string Message(string logLine)
    {
        string[] words = logLine.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return string.Join(" ", words.Skip(1));
    }

    public static string LogLevel(string logLine)
    {
        string[] words = logLine.ToUpper().Split();
        return words[1];
    }

    public static string Reformat(string logLine)
    {
        return $"[{LogLevel}]: {Message}";
    }
}
