using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OTNotes.Business.Interface;
using OTNotes.Business;
using OTNotes.DTO;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace OT_App_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CHGeneralController : ControllerBase
    {
        private readonly ICHGeneralService _chGeneralService;
        private readonly ILogger<CHGeneralController> _logger;

        public CHGeneralController(ICHGeneralService chGeneralService, ILogger<CHGeneralController> logger)
        {
            _chGeneralService = chGeneralService;
            _logger = logger;
        }

        [EnableCors]
        [HttpGet("{visitId}")]
        public async Task<IActionResult> GetHistory(int visitId)
        {
            try
            {
                var chGeneral = await _chGeneralService.GetCHAGeneralByVisitIDAsync(visitId);
                if (chGeneral == null)
                {
                    return NotFound(new ApiResponse<object>
                    {
                        success = false,
                        message = "No data found for the specified visit ID.",
                        data = null
                    });
                }

                return Ok(new ApiResponse<ChGeneralDTO>
                {
                    success = true,
                    message = "Data found successfully.",
                    data = chGeneral
                });
                //return Ok(chGeneral);
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
        public async Task<IActionResult> Post([FromBody] ChGeneralDTO chGeneralDTO)
        {
            try
            {
                // Validate the received data
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ApiResponse<object>
                    {
                        success = false,
                        message = "Invalid data received.",
                        data = ModelState
                    });
                }

                var isSaved = await _chGeneralService.SaveCHGeneralAsync(chGeneralDTO);

                return isSaved
                             ? Ok(new ApiResponse<object>
                             {
                                 success = true,
                                 message = "Case-history data saved successfully!..",
                                 data = null
                             })
                             : BadRequest(new ApiResponse<object>
                             {
                                 success = false,
                                 message = "Failed to save data.",
                                 data = null
                             });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while processing Post request");
                return StatusCode(500, new ApiResponse<object>
                {
                    success = false,
                    message = "An error occurred while processing the request.",
                    data = null
                });
            }
        }
    }
}
