using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevonDev.Models
{
    public class CourseViewModel
    {
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
    }

    public class CourseEnrollmentViewModel
    {
        public int DeveloperId { get; set; }
        public int CourseId { get; set; }
    }
}