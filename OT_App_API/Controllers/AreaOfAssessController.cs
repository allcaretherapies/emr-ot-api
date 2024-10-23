using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OTNotes.Business;
using OTNotes.Business.Interface;
using OTNotes.DTO;

namespace OT_App_API.Controllers
{
   [Authorize(AuthenticationSchemes = "BasicAuthentication")]
    [Route("api/[controller]")]
    [ApiController]
    public class AreaOfAssessController : ControllerBase
    {
        private readonly IAreaOfAssess _areaOfAssess;
        private readonly ILogger<AreaOfAssessController> _logger;

        public AreaOfAssessController(IAreaOfAssess areaOfAssess, ILogger<AreaOfAssessController> logger)
        {
            _areaOfAssess = areaOfAssess;
            _logger = logger;
        }

        [EnableCors]
        [HttpGet("{visitId}")]
        public async Task<IActionResult> GetAreaOfAssess(int visitId)
        {

            var areaOfAssess = await _areaOfAssess.GetAreaOfAssessByVisitIDAsync(visitId);
            if (areaOfAssess == null)
            {
                return Ok(new ApiResponse<object>
                {
                    success = false,
                    message = "No data found.",
                    data = null
                });
            }

            return Ok(new ApiResponse<AreaOfAssessDTO>
            {
                success = true,
                message = "Data found successfully.",
                data = areaOfAssess
            });
            //return Ok(areaOfAssess);

        }

        [EnableCors]
        [HttpPost]
        public async Task<IActionResult> SaveAreaOfAssess([FromBody] AreaOfAssessDTO areaOfAssessDTO)
        {
            
                var status = await _areaOfAssess.SaveAreaOfAssessAsync(areaOfAssessDTO);
                if (status)
                {
                    return Ok(new ApiResponse<object>
                    {
                        success = true,
                        message = "Data saved successfully.",
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
