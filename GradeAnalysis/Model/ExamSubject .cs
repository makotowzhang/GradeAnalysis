using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeAnalysis.Model
{
    public class ExamSubject
    {
        public Guid Id { get; set; }
        public int Sort { get; set; }

        public string  SubjectName { get; set; }

        public SubjectType Type { get; set; }

        public string Description { get; set; }

        public int Grade { get; set; }
    }

    public enum SubjectType
    {
        /// <summary>
        /// 客观题
        /// </summary>
        Objective=1,
        /// <summary>
        /// 主观题
        /// </summary>
        Subjective=2
    }
}
