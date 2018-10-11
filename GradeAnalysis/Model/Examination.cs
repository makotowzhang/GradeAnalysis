using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace GradeAnalysis.Model
{
    [Table("Examination")]
    public class Examination
    {
        public string Id { get; set; }
        public string ExamName { get; set; }

        [NotMapped]
        public List<ExamSubject> Subjects { get; set; }
    }
}
