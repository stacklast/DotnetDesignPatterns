// See https://aka.ms/new-console-template for more information
using DesignPatterns.Singleton;

var log = Log.Instance;

log.Save("This is a log message.");
log.Save("This is another log message.");

var singleton = Log.Instance;
var singleton2 = Log.Instance;
Console.WriteLine($"Are both singleton instances the same? {singleton == singleton2}");
Console.ReadLine();