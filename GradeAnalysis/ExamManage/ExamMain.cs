using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GradeAnalysis.ExamManage
{
    public partial class ExamMain : DevExpress.XtraEditors.XtraForm
    {
        private static ExamMain form;
        public static ExamMain GetStuForm()
        {
            if (form == null || form.IsDisposed)
            {
                form = new ExamMain();
            }
            return form;
        }
        public ExamMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExamAdd examAdd = new ExamAdd();
            examAdd.ShowDialog();
        }
    }
}