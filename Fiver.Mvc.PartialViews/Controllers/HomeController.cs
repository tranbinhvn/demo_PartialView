using Microsoft.AspNetCore.Mvc;
using Fiver.Mvc.PartialViews.Models.Home;

namespace Fiver.Mvc.PartialViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new EmployeeViewModel
            {
                Id = 1,
                Firstname = "James",
                Surname = "Bond",
                Address = new AddressViewModel
                {
                    Line1 = "Secret Location",
                    Line2 = "London",
                    Line3 = "UK",
                    Line4 = "Secret Location",
                    Line5 = "London",
                    Line6 = "UK Secret Location"
                }
            };
            return View(model);
        }
       
    }
}
