using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using SchoolStudentEnrollmentApp.Models;

namespace SchoolStudentEnrollmentApp.Controllers
{
    public class StudentHomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();   
        // GET: StudentHome
        public ActionResult Index()
        {
            //get userId from log in

            var userId = User.Identity.GetUserId();
            //Find User Id 
            var studentId = db.Students.Where(s => s.ApplicationUserId == userId).First().Id;
            //store that in the view bag 
            ViewBag.StudentId = studentId;
            return View();
        }
    }
}