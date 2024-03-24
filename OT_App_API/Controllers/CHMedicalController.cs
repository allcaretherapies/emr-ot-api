using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OTNotes.Business;
using OTNotes.Business.Interface;
using OTNotes.DataAccess.DBObject;
using OTNotes.DTO;
using System;
using System.Threading.Tasks;

namespace OT_App_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CHMedicalController : ControllerBase
    {
        private readonly ICHMedicalService _chMedicalService;
        private readonly ILogger<CHMedicalController> _logger;

        public CHMedicalController(ICHMedicalService chMedicalService, ILogger<CHMedicalController> logger)
        {
            _chMedicalService = chMedicalService;
            _logger = logger;
        }


        [HttpGet("{visitId}")]
        public async Task<IActionResult> GetHistory(int visitId)
        {
            //var data = null;
            try
            {
                var data = await _chMedicalService.GetCHMedicalByVisitIDAsync(visitId);
            if (data == null)
            {
                return NotFound(new ApiResponse<object>
                {
                    success = false,
                    message = "No data found for the specified visit ID.",
                    data = null
                });
            }

            //return Ok(new ApiResponse<ChMedicalDTO>
            //{
            //    Success = true,
            //    Message = "data found successfully.",
            //    data = chGeneral
            //});
            return Ok(data);
                //return Ok(new ApiResponse<string>
                //{
                //    Success = true,
                //    Message = "data found successfully.",
                //    data = "Ashish"
                //});
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while processing Get request for visit ID {VisitId}", visitId);
                return StatusCode(500, new ApiResponse<object>
                {
                    success = false,
                    message = "An error occurred while processing the request.",
                    data = null
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ChMedicalDTO _dTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResponse<object>
                {
                    success = false,
                    message = "Invalid data received.",
                    data = ModelState
                });
            }

            var saved = await _chMedicalService.SaveCHMedicalAsync(_dTO);

            if (saved)
            {
                return Ok(new ApiResponse<object>
                {
                    success = true,
                    message = "data saved successfully.",
                    data = null
                });
            }
            else
            {
                return StatusCode(500, new ApiResponse<object>
                {
                    success = false,
                    message = "An error occurred while saving the data.",
                    data = null
                });
            }
        }
    }
}
