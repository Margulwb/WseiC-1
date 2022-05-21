
using System;
using ConsoleApp.Logger;

namespace lab3.Logger
{
    public class CommonLogger : ILogger
    {
        private ILogger[] loggers;

        public CommonLogger(ILogger[] loggers)
        {
            this.loggers = loggers;
        }

        public void Dispose()
        {
            foreach (var logger in loggers)
            {
                logger.Dispose();
            }
        }

        public void Log(params string[] messages)
        {
            foreach (var logger in loggers)
            {
                logger.Log(messages);
                
            }
        }
    }
}
