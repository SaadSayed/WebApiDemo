using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Example Controller";
        }

        [Route("[action]")]
        [HttpGet]
        public ActionResult HtmlPage()
        {
            string username = "Saad Sayed";

            string style = "font-size: 1.3rem; font-family: Tahoma, Arial, Calibri; ";
            string html = "<label style='" + style + "'>Hello Brothers<br/>Nice to meet you</label>";

            string response = string.Format("<label style='font-size: 1.3rem; font-family: Tahoma, Arial, Calibri;'>Dear {0}, ", username);
            response += "Your credentials have been reset successfully.<br/>" +
                        "You will shortly receive an email with temporary credentials (username & password).<br/>" +
                        "Login with those temporary credentials and proceed with setting up new credentials.<br/><br/>" +
                        "Please don't refresh this page.<br/>" +
                        "Good Luck.</label>";

            return Content(response, "text/html", Encoding.UTF8);
            //return new JsonResult(html);
            //return new ActionResult<object>(html);
        }
    }
}