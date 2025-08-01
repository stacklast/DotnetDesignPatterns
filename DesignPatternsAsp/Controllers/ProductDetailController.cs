using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesignPatternsAsp.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index(decimal total)
        {
            //factories
            LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
            ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m, 20);

            //products
            var localEarn = localEarnFactory.GetEarn();
            var foreignEarn = foreignEarnFactory.GetEarn();

            //total
            ViewBag.TotalLocal = total + localEarn.Earn(total);
            ViewBag.TotalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
