using Business.Abstract;
using Entities.Conctre;
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
    public class CarsController : ControllerBase
    {
        ICarsServices _carsService;

        public CarsController(ICarsServices carsService)
        {
           _carsService = carsService;
        }

        [HttpGet("getcarsbycolorid")]
        public IActionResult GetCarsByColorId(int id)
        {

            var result = _carsService.GetCarsByColorId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcarsbybrandId")]
        public IActionResult GetCarsByBrandId(int id)
        {

            var result = _carsService.GetCarsByBrandId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]

        public IActionResult Add(Cars cars)
        {
            var result = _carsService.Add(cars);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpDelete("delete")]

        public IActionResult Delete(Cars cars)
        {
            var result = _carsService.Delete(cars);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcarsdetails")]
        public IActionResult GetCarsDetails()
        {
            var result = _carsService.GetCarsDetails();


            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
