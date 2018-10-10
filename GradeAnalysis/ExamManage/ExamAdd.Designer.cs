namespace GradeAnalysis.ExamManage
{
    partial class ExamAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamAdd));
            this.GroupSubject = new DevExpress.XtraEditors.GroupControl();
            this.BtnAddSubject = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GroupSubject)).BeginInit();
            this.GroupSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupSubject
            // 
            this.GroupSubject.AllowTouchScroll = true;
            this.GroupSubject.Controls.Add(this.panel1);
            this.GroupSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupSubject.Location = new System.Drawing.Point(0, 63);
            this.GroupSubject.Name = "GroupSubject";
            this.GroupSubject.Size = new System.Drawing.Size(605, 331);
            this.GroupSubject.TabIndex = 0;
            this.GroupSubject.Text = "题目";
            // 
            // BtnAddSubject
            // 
            this.BtnAddSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddSubject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnAddSubject.Location = new System.Drawing.Point(421, 12);
            this.BtnAddSubject.Name = "BtnAddSubject";
            this.BtnAddSubject.Size = new System.Drawing.Size(91, 36);
            this.BtnAddSubject.TabIndex = 1;
            this.BtnAddSubject.Text = "新增题目";
            this.BtnAddSubject.Click += new System.EventHandler(this.BtnAddSubject_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(518, 12);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 36);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "保存";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnAddSubject);
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(605, 63);
            this.groupControl1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 308);
            this.panel1.TabIndex = 0;
            // 
            // ExamAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 394);
            this.Controls.Add(this.GroupSubject);
            this.Controls.Add(this.groupControl1);
            this.Name = "ExamAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExamAdd";
            ((System.ComponentModel.ISupportInitialize)(this.GroupSubject)).EndInit();
            this.GroupSubject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GroupSubject;
        private DevExpress.XtraEditors.SimpleButton BtnAddSubject;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel1;
    }
}