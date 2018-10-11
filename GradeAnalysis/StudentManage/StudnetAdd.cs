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

namespace GradeAnalysis.StudentManage
{
    public partial class StudentAdd : DevExpress.XtraEditors.XtraForm
    {
        public Student student;
        public StudentAdd()
        {
            InitializeComponent();
        }

        public StudentAdd(Student st)
        {
            InitializeComponent();
            student = st;
            txtStuNo.Text = st.StuNo.ToString();
            txtStuName.Text = st.Name;
            Text = "编辑学生";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStuNo.Text) || string.IsNullOrWhiteSpace(txtStuName.Text))
            {
                DialogResult = DialogResult.No;
                return;
            }
            if (student == null)
            {
                student = new Student();
            }
            student.StuNo = int.Parse(txtStuNo.Text ?? "0");
            student.Name = txtStuName.Text;
            DialogResult = DialogResult.OK;
        }

    }
}