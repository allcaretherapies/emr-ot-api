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
            //try
            //{
            var chGeneral = await _chMedicalService.GetCHMedicalByVisitIDAsync(visitId);
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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ChMedicalDTO _dTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Invalid data received.",
                    Data = ModelState
                });
            }

            var saved = await _chMedicalService.SaveCHMedicalAsync(_dTO);

            if (saved)
            {
                return Ok(new ApiResponse<object>
                {
                    Success = true,
                    Message = "Data saved successfully.",
                    Data = null
                });
            }
            else
            {
                return StatusCode(500, new ApiResponse<object>
                {
                    Success = false,
                    Message = "An error occurred while saving the data.",
                    Data = null
                });
            }
        }
    }
}
