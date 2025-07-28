using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesignPatterns.Singleton
{
    public class Log
    {
        private readonly static Log _instance = new Log();
        private string _path = "log.txt";

        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }

        private Log()
        {
            // Private constructor to prevent instantiation from outside
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }
    }
}
