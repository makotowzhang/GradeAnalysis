using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GradeAnalysis.Model;

namespace GradeAnalysis.UserControl
{
    public partial class SubjectControl : DevExpress.XtraEditors.XtraUserControl
    {
        public ExamSubject SubjectItem { get; set; }
        public SubjectControl()
        {
            InitializeComponent();
            SubjectItem = new ExamSubject();
            Init();
        }

        public SubjectControl(ExamSubject item)
        {
            InitializeComponent();
            SubjectItem = item;
            Init();
        }

        private void Init()
        {
            CbbType.Properties.Items.Clear();
            CbbType.Properties.Items.Add(new SubjectTypeCcb { Text = "客观题", Value = SubjectType.Subjective });
            CbbType.Properties.Items.Add(new SubjectTypeCcb { Text = "主观题", Value = SubjectType.Objective });
        }
    }

    public class SubjectTypeCcb
    {
        public string Text { get; set; }

        public SubjectType Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
