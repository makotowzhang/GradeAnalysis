using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeAnalysis.Model
{
    public class Examination
    {
        public Guid Id { get; set; }
        public string ExamNam { get; set; }

        public List<ExamSubject> Subjects { get; set; }
    }
}
