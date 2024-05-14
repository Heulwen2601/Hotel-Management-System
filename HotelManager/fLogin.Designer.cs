namespace HotelManager
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPassWord = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnExit_ = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txbIDCardSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đăng Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(18, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.label4.Location = new System.Drawing.Point(18, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu:";
            // 
            // txbPassWord
            // 
            this.txbPassWord.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.txbPassWord.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.txbPassWord.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.txbPassWord.BorderThickness = 1;
            this.txbPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPassWord.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPassWord.isPassword = true;
            this.txbPassWord.Location = new System.Drawing.Point(23, 217);
            this.txbPassWord.Margin = new System.Windows.Forms.Padding(0);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(470, 36);
            this.txbPassWord.TabIndex = 2;
            this.txbPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPassWord_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(977, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 19;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Đăng Nhập";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnLogin.IdleBorderThickness = 2;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.White;
            this.btnLogin.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnLogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.btnLogin.Location = new System.Drawing.Point(23, 300);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(470, 49);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(23, 76);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(493, 12);
            this.bunifuSeparator1.TabIndex = 28;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnExit_
            // 
            this.btnExit_.ActiveBorderThickness = 1;
            this.btnExit_.ActiveCornerRadius = 20;
            this.btnExit_.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnExit_.ActiveForecolor = System.Drawing.Color.White;
            this.btnExit_.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnExit_.BackColor = System.Drawing.Color.White;
            this.btnExit_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit_.BackgroundImage")));
            this.btnExit_.ButtonText = "Thoát";
            this.btnExit_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit_.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnExit_.IdleBorderThickness = 2;
            this.btnExit_.IdleCornerRadius = 20;
            this.btnExit_.IdleFillColor = System.Drawing.Color.White;
            this.btnExit_.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnExit_.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.btnExit_.Location = new System.Drawing.Point(23, 367);
            this.btnExit_.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnExit_.Name = "btnExit_";
            this.btnExit_.Size = new System.Drawing.Size(470, 49);
            this.btnExit_.TabIndex = 29;
            this.btnExit_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit_.Click += new System.EventHandler(this.btnExit__Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(23, 276);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(493, 12);
            this.bunifuSeparator2.TabIndex = 30;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(194, -36);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(932, 590);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txbIDCardSearch
            // 
            this.txbIDCardSearch.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.txbIDCardSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.txbIDCardSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.txbIDCardSearch.BorderThickness = 1;
            this.txbIDCardSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDCardSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbIDCardSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbIDCardSearch.isPassword = false;
            this.txbIDCardSearch.Location = new System.Drawing.Point(23, 123);
            this.txbIDCardSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txbIDCardSearch.Name = "txbIDCardSearch";
            this.txbIDCardSearch.Size = new System.Drawing.Size(470, 36);
            this.txbIDCardSearch.TabIndex = 1;
            this.txbIDCardSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 436);
            this.Controls.Add(this.txbIDCardSearch);
            this.Controls.Add(this.txbPassWord);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.btnExit_);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPassWord;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExit_;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbIDCardSearch;
    }
}

