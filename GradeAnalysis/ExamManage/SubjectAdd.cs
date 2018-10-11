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

namespace GradeAnalysis.ExamManage
{
    public partial class SubjectAdd : DevExpress.XtraEditors.XtraForm
    {
        public ExamSubject Subject { get; set; }
        public SubjectAdd(int no)
        {
            InitializeComponent();
            Subject = new ExamSubject()
            {
                Id = Guid.NewGuid().ToString(),
                Sort=no,
                Grade=1
            };
        }

        public SubjectAdd(ExamSubject sub)
        {
            InitializeComponent();
            Subject = sub;
            Text = "编辑题目";
        }

        private void SubjectAdd_Load(object sender, EventArgs e)
        {
            CBBType.Properties.Items.Clear();
            CBBType.Properties.Items.Add(new SubjectTypeCcb { Text = "客观题", Value = SubjectType.Objective });
            CBBType.Properties.Items.Add(new SubjectTypeCcb { Text = "主观题", Value = SubjectType.Subjective });
            CBBType.SelectedIndex = 0;

            CBBAnswer.Properties.Items.Clear();
            CBBAnswer.Properties.Items.Add("A");
            CBBAnswer.Properties.Items.Add("B");
            CBBAnswer.Properties.Items.Add("C");
            CBBAnswer.Properties.Items.Add("D");
            CBBAnswer.SelectedIndex = 0;

            valueToForm();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (formToValue())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show("输入错误");
            }
        }

        private void valueToForm()
        {
            TxtSort.Text = Subject.Sort.ToString();
            TxtDesc.Text = Subject.Description;
            txtSubjectName.Text = Subject.SubjectName;
            TxtMark.Text = Subject.Grade.ToString();
            if (Subject.Type == SubjectType.Subjective)
            {
                CBBType.SelectedIndex = 1;
            }
            else
            {
                CBBType.SelectedIndex = 0;
            }
            CBBAnswer.SelectedItem = Subject.Answer ?? "A";
        }

        private bool formToValue()
        {
            try
            {
                Subject.Sort = int.Parse(TxtSort.Text);
                Subject.Description = TxtDesc.Text;
                Subject.SubjectName = txtSubjectName.Text;
                Subject.Grade = int.Parse(TxtMark.Text);
                Subject.Type = ((SubjectTypeCcb)CBBType.SelectedItem).Value;
                Subject.Answer = (string)CBBAnswer.SelectedItem;
                return true;
            }
            catch
            {
                return false;
            }

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