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
        foreach (string item in logsLevel)
        {
            string fixedLogLevel = item.Substring(0, 3);
            if (logLine.Contains(fixedLogLevel))
            {
                Enum.TryParse<LogLevel>(item, true, out LogLevel logSt);
                return (LogLevel)logSt;
            }
        }
                return LogLevel.Unknown;
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.OutputForShortLog() method");
    }
}
