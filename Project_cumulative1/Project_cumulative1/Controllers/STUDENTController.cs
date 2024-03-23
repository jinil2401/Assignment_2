using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_cumulative1.Controllers;
using Project_cumulative1.Models;


namespace Project_cumulative1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        //GET: /Student/List
        public ActionResult List(string SearchKey = null)
        {
            STUDENTDATAController controller = new STUDENTDATAController();
            IEnumerable<Student> Students = controller.ListStudents(SearchKey);
            return View(Students);
        }

        //GET : /Teacher/Show/{id}
        public ActionResult Show(int id)
        {
            STUDENTDATAController controller = new STUDENTDATAController();
            Student NewStudent = controller.FindStudent(id);

            return View(NewStudent);
        }
    }
}