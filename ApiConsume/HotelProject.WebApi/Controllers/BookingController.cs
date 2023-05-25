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
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();

            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBoooking(Booking booking)
        {
            _bookingService.TInsert(booking);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            _bookingService.TDelete(values);

            return Ok();
        }

        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetById(id);

            return Ok(values);
        }

        [HttpPut("UpdateReservation")]
        public IActionResult UpdateReservation(Booking booking)
        {
            _bookingService.TBookingStatusChangeApproved(booking);

            return Ok();
        }

        [HttpPut("UpdateReservation2")]
        public IActionResult UpdateReservation2(int id)
        {
            _bookingService.TBookingStatusChangeApproved2(id);

            return Ok();
        }
    }
}
