using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace OT_App_API.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<GlobalExceptionFilter> _logger;
        private readonly string _logDirectory = "error_logs";

        public GlobalExceptionFilter(ILogger<GlobalExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            // Log the exception
            _logger.LogError(context.Exception, "An unhandled exception occurred.");

            // Write the exception to the log file
            WriteToLogFile(context.Exception);

            // Return an error response
            context.Result = new ObjectResult("An error occurred")
            {
                StatusCode = 500
            };
        }

        private void WriteToLogFile(Exception exception)
        {
            try
            {
                // Create the log directory if it doesn't exist
                if (!Directory.Exists(_logDirectory))
                {
                    Directory.CreateDirectory(_logDirectory);
                }

                // Generate the log file name with the current date
                string logFileName = $"error_{DateTime.UtcNow.ToString("yyyyMMdd")}.log";
                string logFilePath = Path.Combine(_logDirectory, logFileName);

                // Append the exception details to the log file
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine($"Timestamp: {DateTime.UtcNow}");
                    writer.WriteLine($"Exception: {exception.Message}");
                    writer.WriteLine($"StackTrace: {exception.StackTrace}");
                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                // If an error occurs while writing to the log file, log it
                _logger.LogError(ex, "Error writing to log file.");
            }
        }
    }
}
