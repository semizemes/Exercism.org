static class LogLine
{
    public static string Message(string logLine)
    {
        string[] words = logLine.Trim().Split(new [] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
        
        return string.Join(" ", words.Skip(1));
    }

    public static string LogLevel(string logLine)
    {
        string[] words = logLine.ToUpper().Split(' ');
        return words[1];
    }

    public static string Reformat(string logLine)
    {
        string[] words = logLine.Trim().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        string logMessage = string.Join(" ", words.Skip(1));
        string logLevel = words[1].ToLower();
        return $"{logMessage} ({logLevel})";
    }
}
