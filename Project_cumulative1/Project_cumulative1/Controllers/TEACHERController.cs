using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_cumulative1.Controllers;
using Project_cumulative1.Models;



namespace Project_cumulative1.Controllers
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
            IEnumerable<Teacher> Teachers = controller.ListTeachers(SearchKey);
            return View(Teachers);
        }

        //GET : /Teacher/Show/{id}
        public ActionResult Show(int id)
        {
            TEACHERDATAController controller = new TEACHERDATAController();
            Teacher NewTeacher = controller.FindTeacher(id);



            return View(NewTeacher);
        }


    }
}