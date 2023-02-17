using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCalculator.Data;
using WebCalculator.Models;

namespace WebCalculator.Controllers
{
    public class CalculatorsController : Controller
    {
        private readonly WebCalculatorContext _context;

        public CalculatorsController(WebCalculatorContext context)
        {
            _context = context;
        }

        // GET: Calculators
        public async Task<IActionResult> Index()
        {
              return View(await _context.Calculator.ToListAsync());
        }


        // GET: Calculators/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Calculators/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,PrvniCislo,DruheCislo,Result,Operace,Vysledek")] Calculator calculator)
        {
            if (ModelState.IsValid)
            {
                calculator.VypocitejVysledek();

                _context.Add(calculator);
                try
                {

                }
                finally
                {
                    throw new Exception("Neprobehl Update do DB");
                    //calculator.SendError();
                }
                await _context.SaveChangesAsync();
            }
            else
            {
                //calculator.SendError();
                //return RedirectToAction(nameof(Create));
            }

            return View(calculator);
        }

        //private bool CalculatorExists(int id)
        //{
        //  return _context.Calculator.Any(e => e.ID == id);
        //}



    }
}
