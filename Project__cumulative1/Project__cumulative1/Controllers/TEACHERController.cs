using Project__cumulative1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project__cumulative1.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
        //GET: /Teacher/List
        public ActionResult List(string SearchKey = null)
        {
            TEACHERDATAController controller = new TEACHERDATAController();
            IEnumerable<TEACHER> Teachers = controller.ListTeachers(SearchKey);
            return View(Teachers);
        }

        //GET : /Teacher/Show/{id}
        public ActionResult Show(int id)
        {
            TeacherDataController controller = new TEACHERDATAController();
            TEACHER NewTeacher = controller.FindTeacher(id);



            return View(NewTeacher);
        }


    }

    internal class TEACHERDATAController : TeacherDataController
    {
    }
}