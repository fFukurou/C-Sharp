using System.Threading.Channels;

namespace _34_Delegates
{

    // Delegates define a method signature,
    // and any method assigned to a delegate must match this signature.

    // 1. Declaration: 
    // Can declare inside or outside of a class
    public delegate void LogHandler(string message);

    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Instantiation:
            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler += logger.LogToFile;

            // 3. Invocation:
            logHandler("Log this info!");

            foreach(LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occured with error handling");
                }
                catch(Exception ex) 
                {
                    Console.WriteLine($"Exception caught: {ex.Message}");
                }
            }



            if (IsMethodInDelegate(logHandler, logger.LogToFile))
            {
                logHandler -= logger.LogToFile;
                Console.WriteLine($"LotToFile method removed");
            }
            else
            {
                Console.WriteLine($"Method not found.");
            }
            
            //logHandler($"After removing LogToFile");
            InvokeSafely(logHandler, "After removing LogToFile");


        }

        static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHandler = logHandler;
            if(tempLogHandler != null)
            {
                tempLogHandler(message);    
            }

        }

        static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
        {
            if(logHandler == null)
            {
                return false;
            }

            foreach(var d in logHandler.GetInvocationList())
            {
                if (d == (Delegate)method)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
