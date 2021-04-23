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
    public class GearsController : ControllerBase
    {
        IGearService _gearService;

        public GearsController(IGearService gearService)
        {
            _gearService = gearService;
        }
        [HttpPost("add")]
        public IActionResult Add(Gear gear)
        {
            var result = _gearService.Add(gear);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Gear gear)
        {
            var result = _gearService.Update(gear);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Gear gear)
        {
            var result = _gearService.Add(gear);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _gearService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }

}
