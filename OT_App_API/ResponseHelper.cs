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
                    Success = true,
                    Message = "Operation completed successfully.",
                    Data = result
                });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while processing the request.");
                return new ObjectResult(new ApiResponse<object>
                {
                    Success = false,
                    Message = "An error occurred while processing the request.",
                    Data = null
                })
                {
                    StatusCode = 500
                };
            }
        }
    }
}
