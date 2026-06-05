using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppMVCTechCrew.Models;

namespace WebAppMVCTechCrew.Controllers
{
    public class RelationController : Controller
    {
        public readonly AppDb _db;
        public RelationController(AppDb db)
        {
            _db = db;
        }
        public IActionResult AadharInfo()
        {
            var res = _db.aadhar.Include(x => x.pan).ToList();

            //  var res = _db.pan.Include(x => x.aaddhar).ToList();     
            return View(res);
        }
        public IActionResult OneToMany()
        {
            var res = _db.dept.Include(x => x.emps).ToList();
            return View(res);

        }

        public IActionResult Divide() {
            int x = 34, y = 0;
            TempData["res"] = x / y;
            return View();
        }

    }
}
