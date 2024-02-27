using Microsoft.AspNetCore.Mvc;
using OTNotes.Business;
using OTNotes.Business.Interface;
using OTNotes.DTO;

namespace OT_App_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CHMedicalNewController : ControllerBase
    {
        private readonly ICHMedicalService _chMedicalService;
        //private readonly ILogger<CHMedicalController> _logger;

        public CHMedicalNewController(ICHMedicalService chMedicalService)
        {
            _chMedicalService = chMedicalService;
            //_logger = logger;
        }
        // [HttpGet("{visitId}")]
        [HttpGet]
        public async Task<IActionResult> Getdata()
        {

            ////try
            ////{
            var chGeneral = await _chMedicalService.GetCHMedicalByVisitIDAsync(1199);
            if (chGeneral == null)
            {
                return NotFound(new ApiResponse<object>
                {
                    Success = false,
                    Message = "No data found for the specified visit ID.",
                    Data = null
                });
            }

            return Ok(new ApiResponse<ChMedicalDTO>
            {
                Success = true,
                Message = "Data found successfully.",
                Data = chGeneral
            });

            //return Ok(new ApiResponse<string>
            //{
            //    Success = true,
            //    Message = "Data found successfully.",
            //    Data = "Ashish"
            //});
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError(ex, "Error while processing Get request for visit ID {VisitId}", visitId);
            //    return StatusCode(500, new ApiResponse<object>
            //    {
            //        Success = false,
            //        Message = "An error occurred while processing the request.",
            //        Data = null
            //    });
            //}
        }

        [HttpGet("{visitId}")]
        public async Task<IActionResult> GetHistory(int visitId)
        {

            return Ok(new ApiResponse<string>
            {
                Success = true,
                Message = "Data found successfully.",
                Data = "Ashish"
            });
        }
    }
}
