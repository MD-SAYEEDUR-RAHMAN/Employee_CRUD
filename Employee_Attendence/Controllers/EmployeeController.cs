using Employee_Attendence.Data;
using Employee_Attendence.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employee_Attendence.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _db;
        public EmployeeController(EmployeeDbContext db)
        {
            _db = db;
        }
        public IActionResult EmployeeView()
        {
            List<Employee> objCategoryList = _db.MyProperty.ToList();
            return View(objCategoryList);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee obj)
        {
           
            if (ModelState.IsValid)
            {
                _db.MyProperty.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Employee Create Successfully";
                return RedirectToAction("EmployeeView");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Employee? categoryFromDb = _db.MyProperty.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Employee obj)
        {

            if (ModelState.IsValid)
            {
                _db.MyProperty.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Employee Updated Successfully";
                return RedirectToAction("EmployeeView");
            }
            return View();
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = _db.MyProperty.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Employee? categoryFromDb = _db.MyProperty.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Employee? obj = _db.MyProperty.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.MyProperty.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Employee Deleted Successfully";
            return RedirectToAction("EmployeeView");

        }

    }
}
