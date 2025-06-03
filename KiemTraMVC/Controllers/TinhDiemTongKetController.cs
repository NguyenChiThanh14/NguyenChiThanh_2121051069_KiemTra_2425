using Microsoft.AspNetCore.Mvc;
using KiemTraMVC.Models;

namespace KiemTraMVC.Controllers
{
    public class TinhDiemTongKetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TinhDiemTongKet model)
        {
            if (ModelState.IsValid)
            {
                double result = (model.number1 * 60 + model.number2 * 30 + model.number3 * 10) / 100.0;
                ViewBag.KetQua = result;
            }
            return View();
        }
    }
}
