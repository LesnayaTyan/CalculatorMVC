using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebCalculator.Data;
using WebCalculator.Models;

namespace WebCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebCalculatorContext _context;

        public HomeController(WebCalculatorContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Calculator kalkulacka = new Calculator();
            return View(kalkulacka);

           // return View(await _context.Calculator.ToListAsync());

        }




    }
}