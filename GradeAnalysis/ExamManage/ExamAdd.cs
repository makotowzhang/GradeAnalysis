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
        private List<ExamSubject> subjectList;
        public ExamAdd()
        {
            InitializeComponent();
            subjectList = new List<ExamSubject>();  
        }

      

        private void BtnAddSubject_Click(object sender, EventArgs e)
        {
            int no = subjectList.Count == 0 ? 1 : subjectList.Max(m => m.Sort) + 1;
            SubjectAdd addForm = new SubjectAdd(no);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                subjectList.Add(addForm.Subject);
            }
            GridLoadData();
        }

        private void GridLoadData()
        {
            GridControl.DataSource = subjectList;
            GridControl.RefreshDataSource();
        }
    }
}