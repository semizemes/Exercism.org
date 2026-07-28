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
                int logIndex = Array.IndexOf(logShortcut, item)+1;

                LogLevel[] logsArray = (LogLevel[])Enum.GetValues(typeof(LogLevel));
                LogLevel logText = logsArray[logIndex];
                return (LogLevel)logText;
            }
        }

        return LogLevel.Unknown;
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }
}
