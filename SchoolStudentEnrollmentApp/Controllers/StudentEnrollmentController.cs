using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolStudentEnrollmentApp.Models;
using Microsoft.AspNet.Identity;

namespace SchoolStudentEnrollmentApp.Controllers
{
    public class StudentEnrollmentController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();   
        // GET: StudentEnrollment
        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
           //retrive all available courses
            //ViewBag.CourseId = new SelectList(db.Courses, "Id", "Title");
            var courses = new SelectList(db.Courses, "Id", "Title");
            return View(courses);
        }
        [HttpPost]
        public ActionResult Index(Enrollment enrollment)
        {
            if(ModelState.IsValid)
            {
                db.Enrollments.Add(enrollment);
                db.SaveChanges();
                return RedirectToAction("Index", "StudentHome");
            }
            return View();
        }
    }
}