using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GradeAnalysis.UserControl;
using GradeAnalysis.Model;

namespace GradeAnalysis.ExamManage
{
    public partial class ExamAdd : DevExpress.XtraEditors.XtraForm
    {
        private List<ExamSubject> subjectControls;
        public ExamAdd()
        {
            InitializeComponent();
            subjectControls = new List<ExamSubject>();
            panel1.MouseWheel += Panel1_MouseWheel;
            panel1.MouseEnter += Panel1_MouseEnter;
            panel1.Scroll += Panel1_Scroll;
        }

        private void Panel1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
            {
                panel1.VerticalScroll.Value = e.NewValue;
            }
            else
            {
                panel1.HorizontalScroll.Value = e.NewValue;
            }
        }

        private void Panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void Panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            int newValue = (int)(panel1.VerticalScroll.Value + e.Delta * 0.1);
            if (newValue > panel1.VerticalScroll.Maximum)
            {
                panel1.VerticalScroll.Value = panel1.VerticalScroll.Maximum;
            }
            else if (newValue < panel1.VerticalScroll.Minimum)
            {
                panel1.VerticalScroll.Value = panel1.VerticalScroll.Minimum;
            }
            else
            {
                panel1.VerticalScroll.Value = newValue;
            }
        }

        private void BtnAddSubject_Click(object sender, EventArgs e)
        {
            ExamSubject sub = new ExamSubject();
            sub.Sort = subjectControls.Count + 1;
            subjectControls.Add(sub);
            SubjectControl subjectControl = new SubjectControl(sub);
            subjectControl.Top = 20 + 140 * (sub.Sort - 1);
            panel1.Controls.Add(subjectControl);
            //panel1.VerticalScroll.Value = panel1.VerticalScroll.Maximum;
        }
    }
}