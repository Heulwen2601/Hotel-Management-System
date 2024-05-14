namespace HotelManager
{
    partial class fAddStaffType
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddStaffType));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.txbName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.title = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(487, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 58;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txbName
            // 
            this.txbName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.txbName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.txbName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.txbName.BorderThickness = 1;
            this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbName.isPassword = false;
            this.txbName.Location = new System.Drawing.Point(259, 31);
            this.txbName.Margin = new System.Windows.Forms.Padding(0);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(233, 36);
            this.txbName.TabIndex = 57;
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbName_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(8, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 58;
            this.label5.Text = "Tên loại nhân viên:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClose1);
            this.groupBox3.Controls.Add(this.btn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txbName);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.groupBox3.Location = new System.Drawing.Point(7, 72);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(503, 167);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại Nhân Viên";
            // 
            // btnClose1
            // 
            this.btnClose1.ActiveBorderThickness = 1;
            this.btnClose1.ActiveCornerRadius = 20;
            this.btnClose1.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnClose1.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose1.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose1.BackColor = System.Drawing.Color.White;
            this.btnClose1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose1.BackgroundImage")));
            this.btnClose1.ButtonText = "Đóng";
            this.btnClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnClose1.IdleBorderThickness = 2;
            this.btnClose1.IdleCornerRadius = 20;
            this.btnClose1.IdleFillColor = System.Drawing.Color.White;
            this.btnClose1.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnClose1.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.btnClose1.Location = new System.Drawing.Point(261, 108);
            this.btnClose1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(233, 49);
            this.btnClose1.TabIndex = 60;
            this.btnClose1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn
            // 
            this.btn.ActiveBorderThickness = 1;
            this.btn.ActiveCornerRadius = 20;
            this.btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btn.ActiveForecolor = System.Drawing.Color.White;
            this.btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.BackColor = System.Drawing.Color.White;
            this.btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn.BackgroundImage")));
            this.btn.ButtonText = "Cập Nhật";
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btn.IdleBorderThickness = 2;
            this.btn.IdleCornerRadius = 20;
            this.btn.IdleFillColor = System.Drawing.Color.White;
            this.btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.btn.Location = new System.Drawing.Point(9, 108);
            this.btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(233, 49);
            this.btn.TabIndex = 59;
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.title.Location = new System.Drawing.Point(7, 11);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(354, 46);
            this.title.TabIndex = 69;
            this.title.Text = "Thêm Loại Nhân Viên";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(20, 60);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(483, 12);
            this.bunifuSeparator1.TabIndex = 71;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // fAddStaffType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 252);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fAddStaffType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddStaffType";
            this.Load += new System.EventHandler(this.fAddStaffType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbName;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label title;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn;
    }
}