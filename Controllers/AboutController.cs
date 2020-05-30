using Microsoft.AspNetCore.Mvc;

namespace SimpleKonwWebDevelope.Controllers
{
    //属性路由
    [Route("about")]
    public class AboutController
    {
        public AboutController()
        {

        }

        [HttpGet("")]
        public string PhoneArea() => "+86";

        public string Country()
        {
            return "China";
        }
    }
}
