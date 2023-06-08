using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;
        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]
        public IActionResult GuestList()
        {
            var values = _guestService.TGetList();

            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddGuest(Guest Guest)
        {
            _guestService.TInsert(Guest);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var values = _guestService.TGetById(id);
            _guestService.TDelete(values);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGuest(Guest Guest)
        {
            _guestService.TUpdate(Guest);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var values = _guestService.TGetById(id);

            return Ok(values);
        }
    }
}
