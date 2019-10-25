using System;
using System.IO;

namespace Helpers
{
    public class Log
    {
        private static Log logger;
        private static StreamWriter streamWriter;

        private Log()
        {
            streamWriter = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + "Web-Service.log");
        }

        public static Log getInstance()
        {
            if (logger == null)
                logger = new Log();

            return logger;
        }

        public void Escribir(string mensaje)
        {
            string line = String.Format("{0} {1}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), mensaje);
            
            streamWriter.WriteLine(line);
            
            streamWriter.Flush();
        }

    }
}