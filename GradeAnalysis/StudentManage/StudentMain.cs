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
using GradeAnalysis.Entity;

namespace GradeAnalysis.StudentManage
{
    public partial class StudentMain : DevExpress.XtraEditors.XtraForm
    {
        private readonly string studentJsonSource = Application.StartupPath + "\\Data\\Student.json";
        private readonly string examinationJson = Application.StartupPath + "\\Data\\Examination.json";
        public List<Student> studentsList;
        private static StudentMain form;
        public static StudentMain GetStuForm()
        {
            if (form == null||form.IsDisposed)
            {
                form =new StudentMain();
            }
            return form;
        }
        private StudentMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var addForm = new StudentAdd
            {
                StartPosition = FormStartPosition.CenterParent
            };
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var stu = addForm.student;
                stu.Id = Guid.NewGuid().ToString();
                using (DataProvider dp = new DataProvider())
                {
                    dp.Student.Add(addForm.student);
                    dp.SaveChanges();
                }
            }
            addForm.Dispose();
            GridLoadData();
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {
            GridLoadData();
        }

        private void GridLoadData()
        {
            using (DataProvider dp = new DataProvider())
            {
                studentsList = dp.Student.OrderBy(m=>m.StuNo).ToList();
            }
            GridControl.DataSource = studentsList;
            GridControl.RefreshDataSource();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DataGrid.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("请选择要编辑的学生！");
                return;
            }
            var addForm = new StudentAdd((Student)DataGrid.GetRow(DataGrid.GetSelectedRows()[0]))
            {
                StartPosition = FormStartPosition.CenterParent
            }; 
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                using (DataProvider dp = new DataProvider())
                {
                    Student entity = dp.Student.FirstOrDefault(m => m.Id == addForm.student.Id);
                    entity.StuNo = addForm.student.StuNo;
                    entity.Name = addForm.student.Name;
                    dp.SaveChanges();
                }
                 addForm.Dispose();
                GridLoadData();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("是否确认删除该条记录？", "删除确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                studentsList.RemoveAll(m => m.StuNo == ((Student)DataGrid.GetRow(DataGrid.GetSelectedRows()[0])).StuNo);
                JsonDataHelper.SaveJsonData(studentsList, studentJsonSource);
                GridLoadData();
            }
        }
    }
}