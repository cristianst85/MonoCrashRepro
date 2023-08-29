using MonoCrashRepro.Extensions;
using System;

namespace MonoCrashRepro
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.GetCurrentTimeZoneAbbreviation("en-US"));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
