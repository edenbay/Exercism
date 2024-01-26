using System;

static class LogLine
{
    public static string Message(string logLine) => logLine[logLine.IndexOf(' ')..logLine.Length].Trim();

    public static string LogLevel(string logLine) => logLine[1..logLine.IndexOf(']')].Trim().ToLower();

    public static string Reformat(string logLine) => logLine[logLine.IndexOf(' ')..logLine.Length].Trim() + ' ' + '(' +         
    logLine[1..logLine.IndexOf(']')].Trim().ToLower()+')';
}
