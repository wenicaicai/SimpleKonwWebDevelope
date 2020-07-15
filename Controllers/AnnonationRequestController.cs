using ChineseCalendar;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SimpleKonwWebDevelope.Controllers
{
    /// <summary>
    /// WebApi 继承ApiController
    /// Mvc 继承Controller
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AnnonationRequestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(DateTime.Now.ToString());
        }

        [HttpGet("DateChineseName")]
        public IActionResult DateChineseName()
        {
            ChineseCalendar.ChineseCalendar calendar = new ChineseCalendar.ChineseCalendar();
            var lunarDateName = calendar.GetLunarDateName();
            return Ok(lunarDateName);
        }
    }
}
