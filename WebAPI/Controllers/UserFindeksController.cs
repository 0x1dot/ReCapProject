using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserFindeksController : ControllerBase
    {
        IUserFindexPointService _userFindexPointService;
        public UserFindeksController(IUserFindexPointService userFindexPointService)
        {
            _userFindexPointService = userFindexPointService;
        }

        [HttpGet("get")]
        public IActionResult GetUserFindeksPoint(int CustomerId)
        {
            var result = _userFindexPointService.GetFindeksPointByCustomerId(CustomerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("new")]
        public IActionResult NewUserFindeksPoint(UserFindeksPoint userFindeksPoint)
        {
            var result = _userFindexPointService.Add(userFindeksPoint);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateUserFindeksPoint(UserFindeksPoint userFindeksPoint)
        {
            var result = _userFindexPointService.Update(userFindeksPoint);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
