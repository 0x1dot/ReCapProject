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
    public class CreditCardTypesController : ControllerBase
    {
        ICreditCardTypeService _creditCardTypeService;

        public CreditCardTypesController(ICreditCardTypeService creditCardTypeService)
        {
            _creditCardTypeService = creditCardTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _creditCardTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcardtypebyid")]
        public IActionResult GetCardTypeById(int typeId)
        {
            var result = _creditCardTypeService.GetCardTypeById(typeId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(CreditCardType creditCardType)
        {
            var result = _creditCardTypeService.Add(creditCardType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(CreditCardType creditCardType)
        {
            var result = _creditCardTypeService.Update(creditCardType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CreditCardType creditCardType)
        {
            var result = _creditCardTypeService.Delete(creditCardType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
