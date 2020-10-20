using System;
using System.Collections.Generic;

namespace dotnet_core_webapi.Models
{
    public partial class VwCourseStudents
    {
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public int? StudentId { get; set; }
        public string StudentName { get; set; }
    }
}
