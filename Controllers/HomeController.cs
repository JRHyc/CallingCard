using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace CallingCard.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("{first}/{last}/{age}/{color}")] 
        public JsonResult card(string first, string last, int age, string color)
        {
            var info = new
            {
                FirstName = first,
                LastName = last,
                Age = age,
                FavColor = color
            };
            return Json(info);
        }
    }
}