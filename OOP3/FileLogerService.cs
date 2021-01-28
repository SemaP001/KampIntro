using System;

namespace OOP3
{
    class FileLogerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya logandı");
        }
    }

}
