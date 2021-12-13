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
    public class RentalsController : ControllerBase
    {
        IRentalServices _rentalServices;

        public RentalsController(IRentalServices rentalServices)
        {
            _rentalServices = rentalServices;
        }

        [HttpGet("getrentalbyid")]
        public IActionResult GetRentalById(int id)
        {

            var result = _rentalServices.GetRentalById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalServices.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]

        public IActionResult Add(Rentals rentals)
        {
            var result = _rentalServices.Add(rentals);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]

        public IActionResult Delete(Rentals rentals)
        {
            var result = _rentalServices.Delete(rentals);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPatch("update")]
        public IActionResult Update(Rentals rentals)
        {
            var result = _rentalServices.Update(rentals);


            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
