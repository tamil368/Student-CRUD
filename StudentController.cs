// return View();          // Page only
// return Json(data);      // Data only
using crud.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class StudentsController : Controller
{
    private readonly StudentDbContext db;

    public StudentsController(StudentDbContext Db_)
    {
        db = Db_;
    }

    // ===========================
    // VIEW PAGES (NO MODEL)
    // ===========================

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Update()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Details()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Delete()
    {
        return View();
    }

    // ===========================
    // JSON APIs (FOR JAVASCRIPT)
    // ===========================

    [HttpGet]
    public IActionResult GetStudents()
    {
        var students = db.students.ToList();
        return Json(students);
    }

    [HttpGet]
    public IActionResult GetStudentById(int id)
    {
        var student = db.students.Find(id);
        if (student == null)
            return NotFound();

        return Json(student);
    }

    // ===========================
    // FORM SUBMISSIONS
    // ===========================

    [HttpPost]
    public IActionResult Create(Students students)
    {
        if (!ModelState.IsValid)
            return View();

        db.students.Add(students);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Update(Students students)
    {
        if (!ModelState.IsValid)
            return View();

        db.students.Update(students);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var student = db.students.Find(id);
        if (student == null)
            return NotFound();

        db.students.Remove(student);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}
