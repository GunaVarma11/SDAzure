using Microsoft.AspNetCore.Mvc;
using  school_data.Models;

public class StudentController : Controller
{
    public ActionResult Index()
    {
        return View();
    }


    [HttpPost]
    public ActionResult Index(Student model)
    {
        if (ModelState.IsValid)
        {

            return RedirectToAction("Submitted", model);
        }
        else
        {

            return View(model);
        }
    }

    public ActionResult Submitted(Student model)
    {
        return View(model);
    }

}