namespace Tools
{
    //when use sealed this class cannot be inherited
    public sealed class Log
    {
        private static Log _instance = null;
        private string _path;
        private static object _lock = new object();

        public static Log GetInstance(string path = "log.txt")
        {
            // Use a lock to ensure thread safety when creating the instance specially when having multiple threads Tasks
            lock (_lock)
            {
                // If the instance is null, create a new instance
                if (_instance == null)
                {
                    _instance = new Log(path);
                    _instance._path = path;
                }
                return _instance;
            }
        }


        private Log(string path)
        {
            _path = path;
        }



        public void Save(string message)
        {
            File.AppendAllText(_path, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }
    }
}
