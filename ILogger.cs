using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_3__.NET_
{
    public interface ILogger
    {
        void Log(string message);
    }

    // Step 2: Implement the FileLogger class
    public class FileLogger : ILogger
    {
        private readonly string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            File.AppendAllText(_filePath, message + Environment.NewLine);
        }
    }

    // Step 3: Create an abstract decorator class
    public abstract class LoggerDecorator : ILogger
    {
        protected readonly ILogger _logger;

        protected LoggerDecorator(ILogger logger)
        {
            _logger = logger;
        }

        public abstract void Log(string message);
    }

    // Step 4: Implement concrete decorators
    public class TimestampLogger : LoggerDecorator
    {
        public TimestampLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            string timestampedMessage = $"{DateTime.Now}: {message}";
            _logger.Log(timestampedMessage);
        }
    }

    public class ErrorCategorizationLogger : LoggerDecorator
    {
        public ErrorCategorizationLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            string categorizedMessage = $"[ERROR]: {message}";
            _logger.Log(categorizedMessage);
        }
    }
}
