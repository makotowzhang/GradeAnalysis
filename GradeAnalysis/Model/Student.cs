using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace GradeAnalysis.Model
{
    [Table("Student")]
    public class Student
    {
        public string Id { get; set; }
        public int StuNo { get; set; }
        public string Name { get; set; }
    }
}
