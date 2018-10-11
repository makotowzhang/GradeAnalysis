using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using GradeAnalysis.Model;

namespace GradeAnalysis.Entity
{
    class DataProvider : DbContext
    {
        public DataProvider() : base("DataProvider")
        {

        }

        public DbSet<Student> Student { get; set; }

        public DbSet<Examination> Examination { get; set; }

        public DbSet<ExamSubject> ExamSubject { get; set; }
     }
}
