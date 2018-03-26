namespace fingerPrint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEndReg = new DevExpress.XtraEditors.SimpleButton();
            this.btnInitial = new DevExpress.XtraEditors.SimpleButton();
            this.btnVerify = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSerial = new DevExpress.XtraEditors.TextEdit();
            this.txtCount = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIndex = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemoHint = new System.Windows.Forms.TextBox();
            this.imgNO = new DevExpress.XtraEditors.PictureEdit();
            this.imgOK = new DevExpress.XtraEditors.PictureEdit();
            this.picEdite1 = new DevExpress.XtraEditors.PictureEdit();
            this.gvc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtAge = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdite1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEndReg
            // 
            this.btnEndReg.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEndReg.ImageOptions.Image")));
            this.btnEndReg.Location = new System.Drawing.Point(87, 97);
            this.btnEndReg.Name = "btnEndReg";
            this.btnEndReg.Size = new System.Drawing.Size(93, 23);
            this.btnEndReg.TabIndex = 12;
            this.btnEndReg.Text = "انهاء";
            this.btnEndReg.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnInitial
            // 
            this.btnInitial.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInitial.ImageOptions.Image")));
            this.btnInitial.Location = new System.Drawing.Point(186, 97);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(93, 23);
            this.btnInitial.TabIndex = 8;
            this.btnInitial.Text = "ربط الماسح";
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click_1);
            // 
            // btnVerify
            // 
            this.btnVerify.Enabled = false;
            this.btnVerify.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVerify.ImageOptions.Image")));
            this.btnVerify.Location = new System.Drawing.Point(87, 80);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(93, 23);
            this.btnVerify.TabIndex = 11;
            this.btnVerify.Text = "تحقق";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Enabled = false;
            this.btnRegister.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.ImageOptions.Image")));
            this.btnRegister.Location = new System.Drawing.Point(186, 80);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(93, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "تسجيل";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnEndReg);
            this.panelControl1.Controls.Add(this.txtSerial);
            this.panelControl1.Controls.Add(this.txtCount);
            this.panelControl1.Controls.Add(this.btnInitial);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txtIndex);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(17, 9);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(404, 132);
            this.panelControl1.TabIndex = 12;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(35, 11);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Properties.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(244, 20);
            this.txtSerial.TabIndex = 2;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(35, 37);
            this.txtCount.Name = "txtCount";
            this.txtCount.Properties.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(244, 20);
            this.txtCount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "الفهرس";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(35, 71);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Properties.ReadOnly = true;
            this.txtIndex.Size = new System.Drawing.Size(244, 20);
            this.txtIndex.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "العدد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "الرقم التسلسلي";
            // 
            // txtMemoHint
            // 
            this.txtMemoHint.ForeColor = System.Drawing.Color.Black;
            this.txtMemoHint.Location = new System.Drawing.Point(427, 275);
            this.txtMemoHint.Multiline = true;
            this.txtMemoHint.Name = "txtMemoHint";
            this.txtMemoHint.ReadOnly = true;
            this.txtMemoHint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMemoHint.Size = new System.Drawing.Size(213, 291);
            this.txtMemoHint.TabIndex = 16;
            // 
            // imgNO
            // 
            this.imgNO.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgNO.EditValue = global::fingerPrint.Properties.Resources._2;
            this.imgNO.Location = new System.Drawing.Point(594, 226);
            this.imgNO.Name = "imgNO";
            this.imgNO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.imgNO.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("imgNO.Properties.InitialImageOptions.Image")));
            this.imgNO.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgNO.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imgNO.Size = new System.Drawing.Size(46, 44);
            this.imgNO.TabIndex = 19;
            // 
            // imgOK
            // 
            this.imgOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgOK.EditValue = global::fingerPrint.Properties.Resources._1;
            this.imgOK.Location = new System.Drawing.Point(594, 226);
            this.imgOK.Name = "imgOK";
            this.imgOK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.imgOK.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("imgOK.Properties.InitialImageOptions.Image")));
            this.imgOK.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgOK.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imgOK.Size = new System.Drawing.Size(46, 44);
            this.imgOK.TabIndex = 18;
            // 
            // picEdite1
            // 
            this.picEdite1.Cursor = System.Windows.Forms.Cursors.Default;
            this.picEdite1.EditValue = global::fingerPrint.Properties.Resources.指纹空白;
            this.picEdite1.Location = new System.Drawing.Point(427, 9);
            this.picEdite1.Name = "picEdite1";
            this.picEdite1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.picEdite1.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("picEdite1.Properties.InitialImageOptions.Image")));
            this.picEdite1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picEdite1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picEdite1.Size = new System.Drawing.Size(213, 260);
            this.picEdite1.TabIndex = 11;
            // 
            // gvc
            // 
            this.gvc.Location = new System.Drawing.Point(17, 275);
            this.gvc.MainView = this.gridView1;
            this.gvc.Name = "gvc";
            this.gvc.Size = new System.Drawing.Size(404, 291);
            this.gvc.TabIndex = 20;
            this.gvc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gvc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "الاسم";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "العمر";
            this.gridColumn2.FieldName = "Age";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtName);
            this.panelControl2.Controls.Add(this.txtAge);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.btnVerify);
            this.panelControl2.Controls.Add(this.btnRegister);
            this.panelControl2.Location = new System.Drawing.Point(17, 147);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(404, 122);
            this.panelControl2.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(35, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 20);
            this.txtName.TabIndex = 12;
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(35, 54);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(244, 20);
            this.txtAge.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "العمر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "الاسم";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 575);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gvc);
            this.Controls.Add(this.imgNO);
            this.Controls.Add(this.imgOK);
            this.Controls.Add(this.txtMemoHint);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.picEdite1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نضام التحقق من البصمات";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdite1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtSerial;
        private DevExpress.XtraEditors.SimpleButton btnInitial;
        private DevExpress.XtraEditors.TextEdit txtCount;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit picEdite1;
        private System.Windows.Forms.TextBox txtMemoHint;
        private DevExpress.XtraEditors.PictureEdit imgOK;
        private DevExpress.XtraEditors.PictureEdit imgNO;
        private DevExpress.XtraEditors.SimpleButton btnEndReg;
        private DevExpress.XtraEditors.SimpleButton btnVerify;
        private DevExpress.XtraGrid.GridControl gvc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

