using Asp.netCoreMvcCrud.DAL;
using Asp.netCoreMvcCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMvcCrud.Controllers
{
    public class CongeController : Controller
    {
        private readonly EmployeeContext _context;
      

        public CongeController(EmployeeContext context)
        {
            _context = context;

        }

        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}

        // GET: Congee
        public async Task<IActionResult> Index()
        {
            List<Conge> conges = await _context.Conges.Include(x=>x.Employee).ToListAsync();
            return View(conges);
        }

        // GET: Conge/Create
        public IActionResult AddorEdit(int id = 0)
        {
         
           
            ViewBag.Options = new SelectList(
           _context.Employees,
            "EmployeeId",
            "Nom");
            if (id == 0)
                return View(new Conge());
            else
                return View(_context.Conges.Find(id));
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddorEdit( Conge conge,int Employee)
        {
            conge.Employee = _context.Employees.Where(x => x.EmployeeId == Employee).First();
          
            if (ModelState.IsValid)
            {
                if (conge.CongeId == 0)
                    _context.Add(conge);
                else
                    _context.Update(conge);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Options = new SelectList(
          _context.Employees,
           "EmployeeId",
           "Nom");
            return View(conge);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var employee = await _context.Conges.FindAsync(id);
            _context.Conges.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
