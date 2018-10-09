using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using Newtonsoft.Json;
using GradeAnalysis.Model;

namespace GradeAnalysis
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string studentJsonSource=Application.StartupPath + "\\Data\\Student.json";
        private readonly string examinationJson= Application.StartupPath + "\\Data\\Examination.json";
        public List<Student> studentsList;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            studentsList = JsonDataHelper.GetJsonData<List<Student>>(studentJsonSource);
            GridLoadData();
        }

        private void StudentAdd_Click(object sender, EventArgs e)
        {
            var addForm = new StudentAdd
            {
                StartPosition = FormStartPosition.CenterParent
            };
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var stu = addForm.student;
                stu.Id = Guid.NewGuid();
                studentsList.Add(addForm.student);
                studentsList = studentsList.OrderBy(m => m.StuNo).ToList();
            }
            addForm.Dispose();
            JsonDataHelper.SaveJsonData(studentsList, studentJsonSource);
            GridLoadData();
        }

        private void GridLoadData()
        {
            gridControl1.DataSource = studentsList;
            gridControl1.RefreshDataSource();
        }

        private void StudentEdit_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("请选择要编辑的学生！");
                return;
            }
            var addForm = new StudentAdd((Student)gridView1.GetRow(gridView1.GetSelectedRows()[0]))
            {
                StartPosition = FormStartPosition.CenterParent
            }; ;
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                studentsList.FirstOrDefault(m => m.Id == addForm.student.Id).Name = addForm.student.Name;
                addForm.Dispose();
                JsonDataHelper.SaveJsonData(studentsList, studentJsonSource);
                GridLoadData();
            }
        }

        private void StudentDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("是否确认删除该条记录？", "删除确认", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                studentsList.RemoveAll(m => m.StuNo == ((Student)gridView1.GetRow(gridView1.GetSelectedRows()[0])).StuNo);
                JsonDataHelper.SaveJsonData(studentsList, studentJsonSource);
                GridLoadData();
            }
        }
    }
}