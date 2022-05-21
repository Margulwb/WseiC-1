using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.Logger;

namespace Lab3.Logger
{
    public class SocketLogger : ILogger
    {
        private ClientSocket clientSocket;
        private bool disposedValue;

        public SocketLogger(string host, int port)
        {
            this.clientSocket = new ClientSocket(host, port);
        }

        public void Log(params string[] messages)
        {
            try
            {
                foreach (var message in messages) clientSocket.Send(Encoding.UTF8.GetBytes(message));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                    clientSocket.Dispose();

                disposedValue = true;
            }
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        ~SocketLogger()
        {
            Dispose(disposing: false);
        }
    }
}
