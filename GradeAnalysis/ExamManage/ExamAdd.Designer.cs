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
            this.GridControl = new DevExpress.XtraGrid.GridControl();
            this.DataGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumeSubName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CAnswer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnAddSubject = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnEditSubject = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDeleteSubject = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupSubject)).BeginInit();
            this.GroupSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupSubject
            // 
            this.GroupSubject.AllowTouchScroll = true;
            this.GroupSubject.Controls.Add(this.GridControl);
            this.GroupSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupSubject.Location = new System.Drawing.Point(0, 63);
            this.GroupSubject.Name = "GroupSubject";
            this.GroupSubject.Size = new System.Drawing.Size(659, 363);
            this.GroupSubject.TabIndex = 0;
            this.GroupSubject.Text = "题目";
            // 
            // GridControl
            // 
            this.GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl.Location = new System.Drawing.Point(2, 21);
            this.GridControl.MainView = this.DataGrid;
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(655, 340);
            this.GridControl.TabIndex = 0;
            this.GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DataGrid});
            // 
            // DataGrid
            // 
            this.DataGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sort,
            this.ColumeSubName,
            this.CType,
            this.CAnswer,
            this.CGrade,
            this.CDescription});
            this.DataGrid.GridControl = this.GridControl;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.OptionsBehavior.Editable = false;
            this.DataGrid.OptionsView.ShowGroupPanel = false;
            // 
            // Sort
            // 
            this.Sort.Caption = "题号";
            this.Sort.FieldName = "Sort";
            this.Sort.Name = "Sort";
            this.Sort.Visible = true;
            this.Sort.VisibleIndex = 0;
            // 
            // ColumeSubName
            // 
            this.ColumeSubName.Caption = "题目名称";
            this.ColumeSubName.FieldName = "SubjectName";
            this.ColumeSubName.Name = "ColumeSubName";
            this.ColumeSubName.Visible = true;
            this.ColumeSubName.VisibleIndex = 1;
            // 
            // CType
            // 
            this.CType.Caption = "类型";
            this.CType.FieldName = "ShowType";
            this.CType.Name = "CType";
            this.CType.Visible = true;
            this.CType.VisibleIndex = 2;
            // 
            // CAnswer
            // 
            this.CAnswer.Caption = "答案";
            this.CAnswer.FieldName = "Answer";
            this.CAnswer.Name = "CAnswer";
            this.CAnswer.Visible = true;
            this.CAnswer.VisibleIndex = 3;
            // 
            // CGrade
            // 
            this.CGrade.Caption = "分值";
            this.CGrade.FieldName = "Grade";
            this.CGrade.Name = "CGrade";
            this.CGrade.Visible = true;
            this.CGrade.VisibleIndex = 4;
            // 
            // CDescription
            // 
            this.CDescription.Caption = "描述";
            this.CDescription.FieldName = "Description";
            this.CDescription.Name = "CDescription";
            this.CDescription.Visible = true;
            this.CDescription.VisibleIndex = 5;
            // 
            // BtnAddSubject
            // 
            this.BtnAddSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddSubject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddSubject.ImageOptions.Image")));
            this.BtnAddSubject.Location = new System.Drawing.Point(281, 12);
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
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(572, 12);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 36);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "保存";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnEditSubject);
            this.groupControl1.Controls.Add(this.BtnDeleteSubject);
            this.groupControl1.Controls.Add(this.BtnAddSubject);
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(659, 63);
            this.groupControl1.TabIndex = 3;
            // 
            // BtnEditSubject
            // 
            this.BtnEditSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditSubject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditSubject.ImageOptions.Image")));
            this.BtnEditSubject.Location = new System.Drawing.Point(378, 12);
            this.BtnEditSubject.Name = "BtnEditSubject";
            this.BtnEditSubject.Size = new System.Drawing.Size(91, 36);
            this.BtnEditSubject.TabIndex = 4;
            this.BtnEditSubject.Text = "编辑题目";
            // 
            // BtnDeleteSubject
            // 
            this.BtnDeleteSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteSubject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteSubject.ImageOptions.Image")));
            this.BtnDeleteSubject.Location = new System.Drawing.Point(475, 12);
            this.BtnDeleteSubject.Name = "BtnDeleteSubject";
            this.BtnDeleteSubject.Size = new System.Drawing.Size(91, 36);
            this.BtnDeleteSubject.TabIndex = 3;
            this.BtnDeleteSubject.Text = "删除题目";
            // 
            // ExamAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 426);
            this.Controls.Add(this.GroupSubject);
            this.Controls.Add(this.groupControl1);
            this.Name = "ExamAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExamAdd";
            ((System.ComponentModel.ISupportInitialize)(this.GroupSubject)).EndInit();
            this.GroupSubject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GroupSubject;
        private DevExpress.XtraEditors.SimpleButton BtnAddSubject;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView DataGrid;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteSubject;
        private DevExpress.XtraEditors.SimpleButton BtnEditSubject;
        private DevExpress.XtraGrid.Columns.GridColumn Sort;
        private DevExpress.XtraGrid.Columns.GridColumn ColumeSubName;
        private DevExpress.XtraGrid.Columns.GridColumn CType;
        private DevExpress.XtraGrid.Columns.GridColumn CAnswer;
        private DevExpress.XtraGrid.Columns.GridColumn CGrade;
        private DevExpress.XtraGrid.Columns.GridColumn CDescription;
    }
}