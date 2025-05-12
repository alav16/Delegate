/*
Notification System
Create a Notifier class that uses a delegate to send messages.
Allow the delegate to point to different message handlers
(e.g., console output, file logger, or email simulation).
Example of console output : Console.WriteLine($"[Console]: {msg}")
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob2
{
    public delegate void NotifierHandler(string text);

    public class Notifier
    {
        private NotifierHandler handler;

        public void RegisterHandler(NotifierHandler method)
        {
            handler += method;
        }

        public void Send(string message)
        {
            if (handler != null)
            {
                handler(message);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();

            notifier.RegisterHandler(ConsoleOutput);
            notifier.RegisterHandler(FileLogger);
            notifier.RegisterHandler(EmailSimul);

            notifier.Send("System Notification");
            
        }

        public static void ConsoleOutput(string text)
        {
            Console.WriteLine(text);
        }

        public static void FileLogger(string text)
        {
            Console.WriteLine(text);
        }

        public static void EmailSimul(string text)
        {
            Console.WriteLine(text);
        }
    }
}
