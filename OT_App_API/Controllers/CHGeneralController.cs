using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OTNotes.Business.Interface;
using OTNotes.Business;
using OTNotes.DTO;
using System;
using System.Threading.Tasks;

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
                        Success = false,
                        Message = "No data found for the specified visit ID.",
                        Data = null
                    });
                }

                return Ok(new ApiResponse<ChGeneralDTO>
                {
                    Success = true,
                    Message = "Data found successfully.",
                    Data = chGeneral
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while processing Get request for visit ID {VisitId}", visitId);
                return StatusCode(500, new ApiResponse<object>
                {
                    Success = false,
                    Message = "An error occurred while processing the request.",
                    Data = null
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
                        Success = false,
                        Message = "Invalid data received.",
                        Data = ModelState
                    });
                }

                await _chGeneralService.SaveCHGeneralAsync(chGeneralDTO);

                return Ok(new ApiResponse<object>
                {
                    Success = true,
                    Message = "Data saved successfully.",
                    Data = null
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while processing Post request");
                return StatusCode(500, new ApiResponse<object>
                {
                    Success = false,
                    Message = "An error occurred while processing the request.",
                    Data = null
                });
            }
        }
    }
}
