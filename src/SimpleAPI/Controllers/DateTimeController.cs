using System;
using Microsoft.AspNetCore.Mvc;
namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DateTimeController : ControllerBase
    {
        [HttpGet]
        [Route("date")]
        public string Date()
        {
            return DateTime.Now.Date.ToShortDateString();
        }
        [HttpGet]
        [Route("time")]
        public string Time()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}