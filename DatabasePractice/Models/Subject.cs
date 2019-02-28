using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabasePractice.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set;}

        public virtual Teacher Teacher { get; set; }
        public List<StudentSubject> StudentSubjects { get; set; }
    }

}
