namespace GradeAnalysis.StudentManage
{
    partial class StudentAdd
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
            this.txtStuNo = new DevExpress.XtraEditors.TextEdit();
            this.LabelStuNo = new DevExpress.XtraEditors.LabelControl();
            this.LabelStuName = new DevExpress.XtraEditors.LabelControl();
            this.txtStuName = new DevExpress.XtraEditors.TextEdit();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtStuNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStuName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStuNo
            // 
            this.txtStuNo.Location = new System.Drawing.Point(112, 33);
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.Properties.Mask.EditMask = "[0-9]*";
            this.txtStuNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtStuNo.Size = new System.Drawing.Size(100, 20);
            this.txtStuNo.TabIndex = 0;
            // 
            // LabelStuNo
            // 
            this.LabelStuNo.Location = new System.Drawing.Point(54, 36);
            this.LabelStuNo.Name = "LabelStuNo";
            this.LabelStuNo.Size = new System.Drawing.Size(24, 14);
            this.LabelStuNo.TabIndex = 1;
            this.LabelStuNo.Text = "学号";
            // 
            // LabelStuName
            // 
            this.LabelStuName.Location = new System.Drawing.Point(54, 76);
            this.LabelStuName.Name = "LabelStuName";
            this.LabelStuName.Size = new System.Drawing.Size(24, 14);
            this.LabelStuName.TabIndex = 2;
            this.LabelStuName.Text = "姓名";
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(112, 73);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 20);
            this.txtStuName.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(96, 128);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "确定";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // StudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 191);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.LabelStuName);
            this.Controls.Add(this.LabelStuNo);
            this.Controls.Add(this.txtStuNo);
            this.Name = "StudentAdd";
            this.Text = "新增学生";
            ((System.ComponentModel.ISupportInitialize)(this.txtStuNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStuName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtStuNo;
        private DevExpress.XtraEditors.LabelControl LabelStuNo;
        private DevExpress.XtraEditors.LabelControl LabelStuName;
        private DevExpress.XtraEditors.TextEdit txtStuName;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
    }
}