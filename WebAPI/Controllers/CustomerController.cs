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
    public class CustomerController : ControllerBase
    {
        ICustomersServices _customersServices;

        public CustomerController(ICustomersServices customersServices)
        {
            _customersServices = customersServices;
        }

        [HttpGet("getcustomerbyid")]
        public IActionResult GetCustomerById(int id)
        {

            var result = _customersServices.GetCustomerById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customersServices.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
       

        [HttpPost("add")]

        public IActionResult Add(Customers customer)
        {
            var result = _customersServices.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]

        public IActionResult Delete(Customers customer)
        {
            var result = _customersServices.Delete(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPatch("update")]
        public IActionResult Update(Customers customer)
        {
            var result = _customersServices.Update(customer);


            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


    }
}
