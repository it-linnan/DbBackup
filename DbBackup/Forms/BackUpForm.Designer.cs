namespace DbBackup
{
    partial class BackUpForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUpForm));
            this.txtServer = new CCWin.SkinControl.SkinTextBox();
            this.txtDatabase = new CCWin.SkinControl.SkinTextBox();
            this.btnBak = new CCWin.SkinControl.SkinButton();
            this.btnRestore = new CCWin.SkinControl.SkinButton();
            this.txtUid = new CCWin.SkinControl.SkinTextBox();
            this.txtPassword = new CCWin.SkinControl.SkinTextBox();
            this.txtPath = new CCWin.SkinControl.SkinTextBox();
            this.lblServer = new CCWin.SkinControl.SkinLabel();
            this.lblDatabase = new CCWin.SkinControl.SkinLabel();
            this.lblUid = new CCWin.SkinControl.SkinLabel();
            this.lblPassword = new CCWin.SkinControl.SkinLabel();
            this.lblPath = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.Color.Transparent;
            this.txtServer.DownBack = null;
            this.txtServer.Icon = null;
            this.txtServer.IconIsButton = false;
            this.txtServer.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtServer.IsPasswordChat = '\0';
            this.txtServer.IsSystemPasswordChar = false;
            this.txtServer.Lines = new string[0];
            this.txtServer.Location = new System.Drawing.Point(137, 58);
            this.txtServer.Margin = new System.Windows.Forms.Padding(0);
            this.txtServer.MaxLength = 32767;
            this.txtServer.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtServer.MouseBack = null;
            this.txtServer.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtServer.Multiline = false;
            this.txtServer.Name = "txtServer";
            this.txtServer.NormlBack = null;
            this.txtServer.Padding = new System.Windows.Forms.Padding(5);
            this.txtServer.ReadOnly = false;
            this.txtServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServer.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtServer.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServer.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServer.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtServer.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtServer.SkinTxt.Name = "BaseText";
            this.txtServer.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtServer.SkinTxt.TabIndex = 0;
            this.txtServer.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtServer.SkinTxt.WaterText = "服务器地址";
            this.txtServer.TabIndex = 0;
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServer.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtServer.WaterText = "服务器地址";
            this.txtServer.WordWrap = true;
            // 
            // txtDatabase
            // 
            this.txtDatabase.BackColor = System.Drawing.Color.Transparent;
            this.txtDatabase.DownBack = null;
            this.txtDatabase.Icon = null;
            this.txtDatabase.IconIsButton = false;
            this.txtDatabase.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDatabase.IsPasswordChat = '\0';
            this.txtDatabase.IsSystemPasswordChar = false;
            this.txtDatabase.Lines = new string[0];
            this.txtDatabase.Location = new System.Drawing.Point(137, 100);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(0);
            this.txtDatabase.MaxLength = 32767;
            this.txtDatabase.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtDatabase.MouseBack = null;
            this.txtDatabase.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDatabase.Multiline = false;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.NormlBack = null;
            this.txtDatabase.Padding = new System.Windows.Forms.Padding(5);
            this.txtDatabase.ReadOnly = false;
            this.txtDatabase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDatabase.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtDatabase.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatabase.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatabase.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtDatabase.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtDatabase.SkinTxt.Name = "BaseText";
            this.txtDatabase.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtDatabase.SkinTxt.TabIndex = 0;
            this.txtDatabase.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDatabase.SkinTxt.WaterText = "数据库名称";
            this.txtDatabase.TabIndex = 1;
            this.txtDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDatabase.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDatabase.WaterText = "数据库名称";
            this.txtDatabase.WordWrap = true;
            // 
            // btnBak
            // 
            this.btnBak.BackColor = System.Drawing.Color.Transparent;
            this.btnBak.BaseColor = System.Drawing.Color.Silver;
            this.btnBak.BorderColor = System.Drawing.Color.Black;
            this.btnBak.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnBak.DownBack = null;
            this.btnBak.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBak.Location = new System.Drawing.Point(74, 300);
            this.btnBak.MouseBack = null;
            this.btnBak.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBak.Name = "btnBak";
            this.btnBak.NormlBack = null;
            this.btnBak.Size = new System.Drawing.Size(75, 23);
            this.btnBak.TabIndex = 2;
            this.btnBak.Text = "备份";
            this.btnBak.UseVisualStyleBackColor = false;
            this.btnBak.Click += new System.EventHandler(this.btnBak_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.BaseColor = System.Drawing.Color.Silver;
            this.btnRestore.BorderColor = System.Drawing.Color.Black;
            this.btnRestore.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRestore.DownBack = null;
            this.btnRestore.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRestore.Location = new System.Drawing.Point(266, 300);
            this.btnRestore.MouseBack = null;
            this.btnRestore.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.NormlBack = null;
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "恢复";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnResotre_Click);
            // 
            // txtUid
            // 
            this.txtUid.BackColor = System.Drawing.Color.Transparent;
            this.txtUid.DownBack = null;
            this.txtUid.Icon = null;
            this.txtUid.IconIsButton = false;
            this.txtUid.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUid.IsPasswordChat = '\0';
            this.txtUid.IsSystemPasswordChar = false;
            this.txtUid.Lines = new string[0];
            this.txtUid.Location = new System.Drawing.Point(137, 145);
            this.txtUid.Margin = new System.Windows.Forms.Padding(0);
            this.txtUid.MaxLength = 32767;
            this.txtUid.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtUid.MouseBack = null;
            this.txtUid.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUid.Multiline = false;
            this.txtUid.Name = "txtUid";
            this.txtUid.NormlBack = null;
            this.txtUid.Padding = new System.Windows.Forms.Padding(5);
            this.txtUid.ReadOnly = false;
            this.txtUid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUid.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtUid.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUid.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUid.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtUid.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtUid.SkinTxt.Name = "BaseText";
            this.txtUid.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtUid.SkinTxt.TabIndex = 0;
            this.txtUid.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUid.SkinTxt.WaterText = "登录名";
            this.txtUid.TabIndex = 4;
            this.txtUid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUid.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUid.WaterText = "登录名";
            this.txtUid.WordWrap = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.DownBack = null;
            this.txtPassword.Icon = null;
            this.txtPassword.IconIsButton = false;
            this.txtPassword.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPassword.IsPasswordChat = '●';
            this.txtPassword.IsSystemPasswordChar = true;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(137, 189);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtPassword.MouseBack = null;
            this.txtPassword.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NormlBack = null;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtPassword.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPassword.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPassword.SkinTxt.Name = "BaseText";
            this.txtPassword.SkinTxt.PasswordChar = '●';
            this.txtPassword.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtPassword.SkinTxt.TabIndex = 0;
            this.txtPassword.SkinTxt.UseSystemPasswordChar = true;
            this.txtPassword.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPassword.SkinTxt.WaterText = "密码";
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPassword.WaterText = "密码";
            this.txtPassword.WordWrap = true;
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.Transparent;
            this.txtPath.DownBack = null;
            this.txtPath.Icon = null;
            this.txtPath.IconIsButton = false;
            this.txtPath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPath.IsPasswordChat = '\0';
            this.txtPath.IsSystemPasswordChar = false;
            this.txtPath.Lines = new string[0];
            this.txtPath.Location = new System.Drawing.Point(137, 236);
            this.txtPath.Margin = new System.Windows.Forms.Padding(0);
            this.txtPath.MaxLength = 32767;
            this.txtPath.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtPath.MouseBack = null;
            this.txtPath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPath.Multiline = false;
            this.txtPath.Name = "txtPath";
            this.txtPath.NormlBack = null;
            this.txtPath.Padding = new System.Windows.Forms.Padding(5);
            this.txtPath.ReadOnly = false;
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPath.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtPath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPath.SkinTxt.Name = "BaseText";
            this.txtPath.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtPath.SkinTxt.TabIndex = 0;
            this.txtPath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPath.SkinTxt.WaterText = "路径";
            this.txtPath.TabIndex = 5;
            this.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPath.WaterText = "路径";
            this.txtPath.WordWrap = true;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.BackColor = System.Drawing.Color.Transparent;
            this.lblServer.BorderColor = System.Drawing.Color.White;
            this.lblServer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblServer.Location = new System.Drawing.Point(66, 69);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(68, 17);
            this.lblServer.TabIndex = 6;
            this.lblServer.Text = "服务器地址";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.BackColor = System.Drawing.Color.Transparent;
            this.lblDatabase.BorderColor = System.Drawing.Color.White;
            this.lblDatabase.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDatabase.Location = new System.Drawing.Point(66, 111);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(68, 17);
            this.lblDatabase.TabIndex = 7;
            this.lblDatabase.Text = "数据库名称";
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.BackColor = System.Drawing.Color.Transparent;
            this.lblUid.BorderColor = System.Drawing.Color.White;
            this.lblUid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUid.Location = new System.Drawing.Point(90, 156);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(44, 17);
            this.lblUid.TabIndex = 8;
            this.lblUid.Text = "登录名";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.BorderColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassword.Location = new System.Drawing.Point(102, 200);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(32, 17);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "密码";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.BackColor = System.Drawing.Color.Transparent;
            this.lblPath.BorderColor = System.Drawing.Color.White;
            this.lblPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPath.Location = new System.Drawing.Point(102, 247);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(32, 17);
            this.lblPath.TabIndex = 10;
            this.lblPath.Text = "路径";
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(418, 366);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUid);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBak);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BackUpForm";
            this.Text = "数据库备份与恢复";
            this.Load += new System.EventHandler(this.BackUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox txtServer;
        private CCWin.SkinControl.SkinTextBox txtDatabase;
        private CCWin.SkinControl.SkinButton btnBak;
        private CCWin.SkinControl.SkinButton btnRestore;
        private CCWin.SkinControl.SkinTextBox txtUid;
        private CCWin.SkinControl.SkinTextBox txtPassword;
        private CCWin.SkinControl.SkinTextBox txtPath;
        private CCWin.SkinControl.SkinLabel lblServer;
        private CCWin.SkinControl.SkinLabel lblDatabase;
        private CCWin.SkinControl.SkinLabel lblUid;
        private CCWin.SkinControl.SkinLabel lblPassword;
        private CCWin.SkinControl.SkinLabel lblPath;
    }
}

