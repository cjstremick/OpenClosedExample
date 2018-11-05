using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OpenClosedExample.Services;

namespace OpenClosedExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoveController : ControllerBase
    {
        private readonly IMoveService _moveService;

        public MoveController(IMoveService moveService)
        {
            _moveService = moveService;
        }

        [HttpGet]
        [Route("{moveType}/{distance}")]
        public IActionResult PerformMove(string moveType, int distance)
        {
            try
            {
                var result = _moveService.ProcessMove(moveType, distance);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}