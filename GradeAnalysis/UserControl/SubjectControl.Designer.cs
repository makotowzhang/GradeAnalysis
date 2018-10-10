namespace GradeAnalysis.UserControl
{
    partial class SubjectControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelSort = new DevExpress.XtraEditors.LabelControl();
            this.TxtSort = new DevExpress.XtraEditors.TextEdit();
            this.TxtTitle = new DevExpress.XtraEditors.TextEdit();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.TxtGrade = new DevExpress.XtraEditors.TextEdit();
            this.LabelGrade = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.LabelDesc = new DevExpress.XtraEditors.LabelControl();
            this.LabelType = new DevExpress.XtraEditors.LabelControl();
            this.CbbType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGrade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbbType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSort
            // 
            this.LabelSort.Location = new System.Drawing.Point(15, 18);
            this.LabelSort.Name = "LabelSort";
            this.LabelSort.Size = new System.Drawing.Size(24, 14);
            this.LabelSort.TabIndex = 0;
            this.LabelSort.Text = "题号";
            // 
            // TxtSort
            // 
            this.TxtSort.Location = new System.Drawing.Point(61, 15);
            this.TxtSort.Name = "TxtSort";
            this.TxtSort.Size = new System.Drawing.Size(100, 20);
            this.TxtSort.TabIndex = 1;
            this.TxtSort.EditValueChanged += new System.EventHandler(this.TxtSort_EditValueChanged);
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(61, 41);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(100, 20);
            this.TxtTitle.TabIndex = 3;
            // 
            // LabelName
            // 
            this.LabelName.Location = new System.Drawing.Point(15, 44);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(24, 14);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "标题";
            // 
            // TxtGrade
            // 
            this.TxtGrade.Location = new System.Drawing.Point(61, 67);
            this.TxtGrade.Name = "TxtGrade";
            this.TxtGrade.Size = new System.Drawing.Size(100, 20);
            this.TxtGrade.TabIndex = 5;
            // 
            // LabelGrade
            // 
            this.LabelGrade.Location = new System.Drawing.Point(15, 70);
            this.LabelGrade.Name = "LabelGrade";
            this.LabelGrade.Size = new System.Drawing.Size(24, 14);
            this.LabelGrade.TabIndex = 4;
            this.LabelGrade.Text = "分值";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(252, 18);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.AutoHeight = false;
            this.textEdit4.Size = new System.Drawing.Size(210, 95);
            this.textEdit4.TabIndex = 7;
            // 
            // LabelDesc
            // 
            this.LabelDesc.Location = new System.Drawing.Point(183, 58);
            this.LabelDesc.Name = "LabelDesc";
            this.LabelDesc.Size = new System.Drawing.Size(24, 14);
            this.LabelDesc.TabIndex = 6;
            this.LabelDesc.Text = "描述";
            // 
            // LabelType
            // 
            this.LabelType.Location = new System.Drawing.Point(15, 96);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(24, 14);
            this.LabelType.TabIndex = 8;
            this.LabelType.Text = "类型";
            // 
            // CbbType
            // 
            this.CbbType.Location = new System.Drawing.Point(61, 93);
            this.CbbType.Name = "CbbType";
            this.CbbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbbType.Size = new System.Drawing.Size(100, 20);
            this.CbbType.TabIndex = 9;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(487, 49);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "删除";
            // 
            // SubjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.CbbType);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.LabelDesc);
            this.Controls.Add(this.TxtGrade);
            this.Controls.Add(this.LabelGrade);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TxtSort);
            this.Controls.Add(this.LabelSort);
            this.Name = "SubjectControl";
            this.Size = new System.Drawing.Size(579, 136);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGrade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbbType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LabelSort;
        private DevExpress.XtraEditors.TextEdit TxtSort;
        private DevExpress.XtraEditors.TextEdit TxtTitle;
        private DevExpress.XtraEditors.LabelControl LabelName;
        private DevExpress.XtraEditors.TextEdit TxtGrade;
        private DevExpress.XtraEditors.LabelControl LabelGrade;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl LabelDesc;
        private DevExpress.XtraEditors.LabelControl LabelType;
        private DevExpress.XtraEditors.ComboBoxEdit CbbType;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
    }
}
