using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolStudentEnrollmentApp.Models
{
    public enum Grade
    {
        A, B, C, D, F, W, I, P
    }
    public class Enrollment
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; } //Nullable attribute

        public virtual Course Course { get; set; } //Virtual are needed for the relationship 
        public virtual Student Student { get; set; }

    }
}