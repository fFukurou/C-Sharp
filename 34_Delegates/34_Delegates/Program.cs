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

            // 3. Invocation:
            logHandler("Logging to console");

            logHandler = logger.LogToFile;
            logHandler("Logging to file");


        }
    }
}
