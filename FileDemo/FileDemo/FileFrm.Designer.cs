namespace FileDemo
{
    partial class FileFrm
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
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnCLear = new System.Windows.Forms.Button();
            this.txtFliter = new System.Windows.Forms.TextBox();
            this.chkEmptyFolder = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(31, 17);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(113, 39);
            this.btnPath.TabIndex = 0;
            this.btnPath.Text = "选择路径";
            this.btnPath.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(31, 62);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(453, 25);
            this.txtPath.TabIndex = 1;
            // 
            // btnCLear
            // 
            this.btnCLear.Location = new System.Drawing.Point(219, 214);
            this.btnCLear.Name = "btnCLear";
            this.btnCLear.Size = new System.Drawing.Size(141, 90);
            this.btnCLear.TabIndex = 2;
            this.btnCLear.Text = "Clear";
            this.btnCLear.UseVisualStyleBackColor = true;
            // 
            // txtFliter
            // 
            this.txtFliter.Location = new System.Drawing.Point(31, 159);
            this.txtFliter.Name = "txtFliter";
            this.txtFliter.Size = new System.Drawing.Size(453, 25);
            this.txtFliter.TabIndex = 3;
            // 
            // chkEmptyFolder
            // 
            this.chkEmptyFolder.AutoSize = true;
            this.chkEmptyFolder.Location = new System.Drawing.Point(31, 190);
            this.chkEmptyFolder.Name = "chkEmptyFolder";
            this.chkEmptyFolder.Size = new System.Drawing.Size(134, 19);
            this.chkEmptyFolder.TabIndex = 4;
            this.chkEmptyFolder.Text = "是否删除空文件";
            this.chkEmptyFolder.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 407);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnCLear);
            this.tabPage1.Controls.Add(this.chkEmptyFolder);
            this.tabPage1.Controls.Add(this.btnPath);
            this.tabPage1.Controls.Add(this.txtFliter);
            this.tabPage1.Controls.Add(this.txtPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "删除文件";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "删除带扩展名的文件：如exe,txt,sql";
            // 
            // FileFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 407);
            this.Controls.Add(this.tabControl1);
            this.Name = "FileFrm";
            this.Text = "空文件";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnCLear;
        private System.Windows.Forms.TextBox txtFliter;
        private System.Windows.Forms.CheckBox chkEmptyFolder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

