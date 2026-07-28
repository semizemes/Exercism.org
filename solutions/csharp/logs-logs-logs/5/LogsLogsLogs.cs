// TODO: define the 'LogLevel' enum
enum LogLevel
{
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
    Unknown = 0
}
static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        string[] logsLevel = Enum.GetNames<LogLevel>();

        string[] logShortcut = new string[] { };

        logShortcut[1] = "TRC";
        logShortcut[2] = "DBG";
        logShortcut[4] = "INF";
        logShortcut[5] = "WRN";
        logShortcut[6] = "ERR";
        logShortcut[42] = "FTL";

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
