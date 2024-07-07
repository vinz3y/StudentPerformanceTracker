using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using StudentPerformanceTracker.models;

namespace StudentPerformanceTracker.studentData
{
    internal class StudentData
    {
        public static string studentName;
        public static List<Subject> subjectsData = new List<Subject>();
        public static List<StudySession> studySessions = new List<StudySession>();
        public static List<BreakSession> breakSessions = new List<BreakSession>();
    }
}
