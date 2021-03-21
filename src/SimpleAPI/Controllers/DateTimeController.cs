using System;
using Microsoft.AspNetCore.Mvc;
namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DateTimeController : ControllerBase
    {
        [HttpGet]
        public string Date()
        {
            return DateTime.Now.Date.ToShortDateString();
        }
        public string Time()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}