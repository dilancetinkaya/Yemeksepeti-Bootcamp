using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhiteList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet(Name = nameof(GetRoot))]
        public IActionResult GetRoot()
        {
            var response = new
            {
                WhiteList = new
                {
                    Ip = "::1",
                    Allows = new
                    {
                        AlbumsController = "/api/albums",
                        RootController = "/api/root"
                    }
                },
                href = Url.Link(nameof(GetRoot), null),
                Albums = new
                {
                    href = Url.Link(nameof(CustomerController.GetCustomer), null)
                },
                Songs = new
                {
                    href = Url.Link(nameof(PersonelController.GetPersonel), null)
                },
            };

            return Ok(response);
        }
    }
}

  