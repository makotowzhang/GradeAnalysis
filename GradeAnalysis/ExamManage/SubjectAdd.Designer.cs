namespace GradeAnalysis.ExamManage
{
    partial class SubjectAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSort = new DevExpress.XtraEditors.TextEdit();
            this.txtSubjectName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBBType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CBBAnswer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.TxtDesc = new DevExpress.XtraEditors.MemoEdit();
            this.TxtMark = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBBType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBBAnswer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMark.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "题号";
            // 
            // TxtSort
            // 
            this.TxtSort.Location = new System.Drawing.Point(104, 36);
            this.TxtSort.Name = "TxtSort";
            this.TxtSort.Size = new System.Drawing.Size(100, 20);
            this.TxtSort.TabIndex = 1;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(104, 64);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(100, 20);
            this.txtSubjectName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "题目名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "题目类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "题目答案";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "描述";
            // 
            // CBBType
            // 
            this.CBBType.Location = new System.Drawing.Point(104, 116);
            this.CBBType.Name = "CBBType";
            this.CBBType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBBType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBBType.Size = new System.Drawing.Size(100, 20);
            this.CBBType.TabIndex = 9;
            // 
            // CBBAnswer
            // 
            this.CBBAnswer.Location = new System.Drawing.Point(104, 142);
            this.CBBAnswer.Name = "CBBAnswer";
            this.CBBAnswer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBBAnswer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBBAnswer.Size = new System.Drawing.Size(100, 20);
            this.CBBAnswer.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(73, 262);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "保存";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(104, 168);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(100, 82);
            this.TxtDesc.TabIndex = 12;
            // 
            // TxtMark
            // 
            this.TxtMark.Location = new System.Drawing.Point(104, 90);
            this.TxtMark.Name = "TxtMark";
            this.TxtMark.Size = new System.Drawing.Size(100, 20);
            this.TxtMark.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "分值";
            // 
            // SubjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 341);
            this.Controls.Add(this.TxtMark);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.CBBAnswer);
            this.Controls.Add(this.CBBType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSort);
            this.Controls.Add(this.label1);
            this.Name = "SubjectAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增题目";
            this.Load += new System.EventHandler(this.SubjectAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBBType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBBAnswer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMark.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtSort;
        private DevExpress.XtraEditors.TextEdit txtSubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit CBBType;
        private DevExpress.XtraEditors.ComboBoxEdit CBBAnswer;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.MemoEdit TxtDesc;
        private DevExpress.XtraEditors.TextEdit TxtMark;
        private System.Windows.Forms.Label label6;
    }
}