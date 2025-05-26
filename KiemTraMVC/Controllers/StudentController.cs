using MvcMovie.Models;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.InfoMessage = "Nhập điểm các thành phần A, B, C để tính điểm tổng kết:";
            return View();
        }

    
        [HttpPost]
        public IActionResult Index(Student st)
        {
    
        Console.WriteLine($"A: {st.PointA}, B: {st.PointB}, C: {st.PointC}");

        double finalScore = st.CalculateFinalScore();
        ViewBag.InfoMessage = $"Điểm tổng kết của {st.FullName} là: {finalScore}";
        return View(st);
        }
    }
}