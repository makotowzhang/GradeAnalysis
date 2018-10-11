using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace GradeAnalysis.Model
{
    [Table("ExamSubject")]
    public class ExamSubject
    {
        public string Id { get; set; }
        public int Sort { get; set; }

        public string  SubjectName { get; set; }

        public string Answer { get; set; }

        public SubjectType Type { get; set; }

        public string Description { get; set; }

        public int Grade { get; set; }

        public string ExameId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public string ShowType
        {
            get
            {
                if (Type == SubjectType.Objective)
                {
                    return "客观题";
                }
                if (Type == SubjectType.Subjective)
                {
                    return "主观题";
                }
                return "";
            }
        }

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
