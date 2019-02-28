using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabasePractice.Models
{
    public class StudentSubject
    {
        public int StudentSubjectId { get; set; }   
        
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
