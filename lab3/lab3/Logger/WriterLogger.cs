using System;
using System.IO;

namespace ConsoleApp.Logger
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            writer.Write($"{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss:K")} ");
            string endline = (messages.Length != 1) ? " " : "\n";

            foreach (var message in messages)
            {

                writer.Write($"{message}{endline}");
            }
            writer.Flush();
        }
        public abstract void Dispose();
    }
}