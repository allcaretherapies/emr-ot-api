using Microsoft.AspNetCore.Mvc;
using OTNotes.Business;

namespace OT_App_API
{
    public class ResponseHelper
    {
        public static IActionResult HandleResponse<T>(Func<T> action, ILogger logger)
        {
            try
            {
                T result = action();
                return new OkObjectResult(new ApiResponse<T>
                {
                    success = true,
                    message = "Operation completed successfully.",
                    data = result
                });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while processing the request.");
                return new ObjectResult(new ApiResponse<object>
                {
                    success = false,
                    message = "An error occurred while processing the request.",
                    data = null
                })
                {
                    StatusCode = 500
                };
            }
        }
    }
}
