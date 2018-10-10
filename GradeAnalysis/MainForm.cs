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
using GradeAnalysis.StudentManage;

namespace GradeAnalysis
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

         
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StudentMain stuForm = StudentMain.GetStuForm();
            stuForm.MdiParent = this;
            stuForm.Show();
            stuForm.Activate();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExamManage.ExamMain exForm = ExamManage.ExamMain.GetStuForm();
            exForm.MdiParent = this;
            exForm.Show();
            exForm.Activate();
           
        }
    }
}