using System;
using System.Diagnostics;

namespace EventLogExample
{
    class MySample
    {
        private const string EventLogSource = "EventLog Demo App";

        public static void Main()
        {
            if (!EventLog.SourceExists(EventLogSource))
            {
                EventLog.CreateEventSource(EventLogSource, "MyNewLog");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Please restart application");
                Console.ReadKey();
                return;
            }
            EventLog myLog = new EventLog();
            myLog.Source = EventLogSource;
            myLog.WriteEntry("Log event!");
        }
    }
}
