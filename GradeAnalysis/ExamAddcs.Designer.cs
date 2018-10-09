namespace GradeAnalysis
{
    partial class ExamAddcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExamTop = new System.Windows.Forms.GroupBox();
            this.ItemPanel = new System.Windows.Forms.Panel();
            this.SubjectItemGroup = new System.Windows.Forms.GroupBox();
            this.LableTitle = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.AddSubject = new DevExpress.XtraEditors.SimpleButton();
            this.ExamTop.SuspendLayout();
            this.SubjectItemGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ExamTop
            // 
            this.ExamTop.Controls.Add(this.AddSubject);
            this.ExamTop.Controls.Add(this.textEdit1);
            this.ExamTop.Controls.Add(this.LableTitle);
            this.ExamTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExamTop.Location = new System.Drawing.Point(0, 0);
            this.ExamTop.Name = "ExamTop";
            this.ExamTop.Size = new System.Drawing.Size(722, 51);
            this.ExamTop.TabIndex = 0;
            this.ExamTop.TabStop = false;
            // 
            // ItemPanel
            // 
            this.ItemPanel.AutoScroll = true;
            this.ItemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemPanel.Location = new System.Drawing.Point(3, 18);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(716, 324);
            this.ItemPanel.TabIndex = 0;
            // 
            // SubjectItemGroup
            // 
            this.SubjectItemGroup.Controls.Add(this.ItemPanel);
            this.SubjectItemGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectItemGroup.Location = new System.Drawing.Point(0, 51);
            this.SubjectItemGroup.Name = "SubjectItemGroup";
            this.SubjectItemGroup.Size = new System.Drawing.Size(722, 345);
            this.SubjectItemGroup.TabIndex = 1;
            this.SubjectItemGroup.TabStop = false;
            this.SubjectItemGroup.Text = "题目";
            // 
            // LableTitle
            // 
            this.LableTitle.Location = new System.Drawing.Point(37, 21);
            this.LableTitle.Name = "LableTitle";
            this.LableTitle.Size = new System.Drawing.Size(48, 14);
            this.LableTitle.TabIndex = 0;
            this.LableTitle.Text = "考试名称";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(117, 18);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(169, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // AddSubject
            // 
            this.AddSubject.Location = new System.Drawing.Point(317, 17);
            this.AddSubject.Name = "AddSubject";
            this.AddSubject.Size = new System.Drawing.Size(75, 23);
            this.AddSubject.TabIndex = 2;
            this.AddSubject.Text = "新增题目";
            // 
            // ExamAddcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 396);
            this.Controls.Add(this.SubjectItemGroup);
            this.Controls.Add(this.ExamTop);
            this.Name = "ExamAddcs";
            this.Text = "ExamAddcs";
            this.ExamTop.ResumeLayout(false);
            this.ExamTop.PerformLayout();
            this.SubjectItemGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ExamTop;
        private System.Windows.Forms.Panel ItemPanel;
        private System.Windows.Forms.GroupBox SubjectItemGroup;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl LableTitle;
        private DevExpress.XtraEditors.SimpleButton AddSubject;
    }
}