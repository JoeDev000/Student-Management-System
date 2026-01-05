using FinalProject.Data;
using FinalProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class StudentsController : Controller
    {
        private ApplicationDbContext context;
        public StudentsController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var students = context.Students.ToList();
            return View(students);
        }

        // GET: Students/Details/5
        public IActionResult Details(int id)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                context.Students.Add(student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public IActionResult Edit(int id)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                context.Students.Update(student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public IActionResult Delete(int id)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
