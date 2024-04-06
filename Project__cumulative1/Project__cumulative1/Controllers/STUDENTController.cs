using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project__cumulative1.Controllers;
using Project__cumulative1.Models;


namespace Project__cumulative1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        //GET: /Student/List
        public ActionResult List()
        {
            StudentDataController controller = new StudentDataController();
            IEnumerable<STUDENT> Students = controller.ListStudents();
            return View(Students);
        }

        
        public ActionResult Show(int id)
        {
            StudentDataController controller = new StudentDataController();
            STUDENT NewStudent = controller.FindStudent(id);

            return View(NewStudent);
        }
    }

}