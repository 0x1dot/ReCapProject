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
    public class FuelsController : ControllerBase
    {
        IFuelService _fuelService;

        public FuelsController(IFuelService fuelService)
        {
            _fuelService = fuelService;
        }
        [HttpPost("add")]
        public IActionResult Add(Fuel fuel)
        {
            var result = _fuelService.Add(fuel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Fuel fuel)
        {
            var result = _fuelService.Update(fuel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Fuel fuel)
        {
            var result = _fuelService.Add(fuel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _fuelService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
