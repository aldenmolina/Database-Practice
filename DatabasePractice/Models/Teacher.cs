using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabasePractice.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }

        public virtual List<Subject> Subjects { get; set; }
    }
}
