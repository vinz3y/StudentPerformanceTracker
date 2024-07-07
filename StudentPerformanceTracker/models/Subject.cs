using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceTracker.models
{
    internal class Subject
    {
        public string SubjectName { get; set; }
        public string SubjectId { get; set; }


        public Subject(string subjectName)
        {
            SubjectName = subjectName;
        }



    }

    
}
