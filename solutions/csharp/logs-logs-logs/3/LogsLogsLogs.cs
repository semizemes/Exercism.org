// TODO: define the 'LogLevel' enum
enum LogLevel
{
    Trace,
    Debug,
    Info,
    Warning,
    Error,
    Fatal,
    Unknown 
}
static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        string[] logsLevel = Enum.GetNames<LogLevel>();

        string[] logShortcut = new string[] 
        {
            "TRC", 
            "DBG", 
            "INF",
            "WRN",
            "ERR",
            "FTL"
        };

        foreach (string item in logShortcut)
        {
            if (logLine.Contains(item))
            {
                int logIndex = Array.IndexOf(logShortcut, item);
                return (LogLevel)logIndex;
            }
        }

        return LogLevel.Unknown;
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }
}
