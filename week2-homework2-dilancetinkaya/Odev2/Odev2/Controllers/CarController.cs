using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odev2.Attributes;
using Odev2.Data;
using Odev2.Data.Entity.Abstract;
using Odev2.Data.Entity.Concrete;
using Odev2.Mapping;
using Odev2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Odev2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase

    {
        private DatabaseContext _context;
        public CarController(DatabaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<CarAd> datas = _context.Cars.ToList();
            List<CarDTO> result = datas.CarMapping();

            return Ok(result);
        }

        [HttpPost]
        [ValidationActionModel]
        public IActionResult Post([FromBody] AdvertisementRequest request)
        {

            #region Valdiation
            var context = new ValidationContext(request);
            var validationResult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(request, context, validationResult, true);
            if (!isValid)
                return BadRequest(validationResult);

            #endregion Valdiation

            return Ok();
        }

    }
}
