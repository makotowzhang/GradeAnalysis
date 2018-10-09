using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GradeAnalysis.Model;

namespace GradeAnalysis
{
    public partial class ExamAddcs : DevExpress.XtraEditors.XtraForm
    {
        public Examination Exam { get; set; }
        public ExamAddcs()
        {
            InitializeComponent();
            Exam = new Examination();
        }
    }
}