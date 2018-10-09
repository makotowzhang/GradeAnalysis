namespace GradeAnalysis
{
    partial class MainForm
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
            this.MenuTab = new System.Windows.Forms.TabControl();
            this.StudentTab = new System.Windows.Forms.TabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StudentTop = new System.Windows.Forms.GroupBox();
            this.StudentDelete = new DevExpress.XtraEditors.SimpleButton();
            this.StudentEdit = new DevExpress.XtraEditors.SimpleButton();
            this.StudentAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StuNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StuName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MenuTab.SuspendLayout();
            this.StudentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.StudentTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTab
            // 
            this.MenuTab.Controls.Add(this.StudentTab);
            this.MenuTab.Controls.Add(this.tabPage2);
            this.MenuTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuTab.Location = new System.Drawing.Point(0, 0);
            this.MenuTab.Name = "MenuTab";
            this.MenuTab.SelectedIndex = 0;
            this.MenuTab.Size = new System.Drawing.Size(778, 538);
            this.MenuTab.TabIndex = 0;
            // 
            // StudentTab
            // 
            this.StudentTab.Controls.Add(this.gridControl1);
            this.StudentTab.Controls.Add(this.StudentTop);
            this.StudentTab.Location = new System.Drawing.Point(4, 23);
            this.StudentTab.Name = "StudentTab";
            this.StudentTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentTab.Size = new System.Drawing.Size(770, 511);
            this.StudentTab.TabIndex = 0;
            this.StudentTab.Text = "学生管理";
            this.StudentTab.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 55);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(764, 453);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.StuNo,
            this.StuName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // StudentTop
            // 
            this.StudentTop.Controls.Add(this.StudentDelete);
            this.StudentTop.Controls.Add(this.StudentEdit);
            this.StudentTop.Controls.Add(this.StudentAdd);
            this.StudentTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentTop.Location = new System.Drawing.Point(3, 3);
            this.StudentTop.Name = "StudentTop";
            this.StudentTop.Size = new System.Drawing.Size(764, 52);
            this.StudentTop.TabIndex = 0;
            this.StudentTop.TabStop = false;
            // 
            // StudentDelete
            // 
            this.StudentDelete.Location = new System.Drawing.Point(222, 21);
            this.StudentDelete.Name = "StudentDelete";
            this.StudentDelete.Size = new System.Drawing.Size(75, 23);
            this.StudentDelete.TabIndex = 2;
            this.StudentDelete.Text = "删除";
            this.StudentDelete.Click += new System.EventHandler(this.StudentDelete_Click);
            // 
            // StudentEdit
            // 
            this.StudentEdit.Location = new System.Drawing.Point(118, 21);
            this.StudentEdit.Name = "StudentEdit";
            this.StudentEdit.Size = new System.Drawing.Size(75, 23);
            this.StudentEdit.TabIndex = 1;
            this.StudentEdit.Text = "修改";
            this.StudentEdit.Click += new System.EventHandler(this.StudentEdit_Click);
            // 
            // StudentAdd
            // 
            this.StudentAdd.Location = new System.Drawing.Point(15, 21);
            this.StudentAdd.Name = "StudentAdd";
            this.StudentAdd.Size = new System.Drawing.Size(75, 23);
            this.StudentAdd.TabIndex = 0;
            this.StudentAdd.Text = "新增";
            this.StudentAdd.Click += new System.EventHandler(this.StudentAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StuNo
            // 
            this.StuNo.Caption = "学号";
            this.StuNo.FieldName = "StuNo";
            this.StuNo.Name = "StuNo";
            this.StuNo.Visible = true;
            this.StuNo.VisibleIndex = 0;
            // 
            // StuName
            // 
            this.StuName.Caption = "姓名";
            this.StuName.FieldName = "Name";
            this.StuName.Name = "StuName";
            this.StuName.Visible = true;
            this.StuName.VisibleIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 538);
            this.Controls.Add(this.MenuTab);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuTab.ResumeLayout(false);
            this.StudentTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.StudentTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MenuTab;
        private System.Windows.Forms.TabPage StudentTab;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox StudentTop;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraEditors.SimpleButton StudentDelete;
        private DevExpress.XtraEditors.SimpleButton StudentEdit;
        private DevExpress.XtraEditors.SimpleButton StudentAdd;
        private DevExpress.XtraGrid.Columns.GridColumn StuNo;
        private DevExpress.XtraGrid.Columns.GridColumn StuName;
    }
}