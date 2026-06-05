using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCTechCrew.Controllers
{
    public class StateManagementController : Controller
    {
        public IActionResult Page1()
        {
            ViewBag.vbmessage = "Viewbag data ex:" + System.DateTime.Now.ToString();
            ViewData["vdmessage"] = "ViewData data ex:" + System.DateTime.Now.ToString();
            TempData["tdmessage"] = "TempData data ex:" + System.DateTime.Now.ToString();
          //  return View();
           return RedirectToAction("Page2");    // td destination ends here
        }
        public IActionResult Page2()
        {

            return RedirectToAction("Page3");
        }
        public IActionResult Page3()
        {
            return View();
        }
        public IActionResult Page4()
        {
            return View();
        }
        public IActionResult Page5()
        {
            return View();
        }
    }
}
