namespace DownloadVideo
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDownload = new System.Windows.Forms.Button();
            this.TxtVideoUrl = new System.Windows.Forms.TextBox();
            this.TxtResult = new System.Windows.Forms.RichTextBox();
            this.BtnGetVideoUrl = new System.Windows.Forms.Button();
            this.txtVideoTitle = new System.Windows.Forms.Label();
            this.BtnAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDownload
            // 
            this.BtnDownload.Location = new System.Drawing.Point(361, 219);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(95, 23);
            this.BtnDownload.TabIndex = 0;
            this.BtnDownload.Text = "下载";
            this.BtnDownload.UseVisualStyleBackColor = true;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // TxtVideoUrl
            // 
            this.TxtVideoUrl.Location = new System.Drawing.Point(130, 12);
            this.TxtVideoUrl.Name = "TxtVideoUrl";
            this.TxtVideoUrl.Size = new System.Drawing.Size(418, 21);
            this.TxtVideoUrl.TabIndex = 1;
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(130, 66);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtResult.Size = new System.Drawing.Size(418, 147);
            this.TxtResult.TabIndex = 2;
            this.TxtResult.Text = "";
            // 
            // BtnGetVideoUrl
            // 
            this.BtnGetVideoUrl.Location = new System.Drawing.Point(179, 219);
            this.BtnGetVideoUrl.Name = "BtnGetVideoUrl";
            this.BtnGetVideoUrl.Size = new System.Drawing.Size(143, 23);
            this.BtnGetVideoUrl.TabIndex = 3;
            this.BtnGetVideoUrl.Text = "解析视频地址";
            this.BtnGetVideoUrl.UseVisualStyleBackColor = true;
            this.BtnGetVideoUrl.Click += new System.EventHandler(this.BtnGetVideoUrl_Click);
            // 
            // txtVideoTitle
            // 
            this.txtVideoTitle.AutoSize = true;
            this.txtVideoTitle.Location = new System.Drawing.Point(133, 45);
            this.txtVideoTitle.Name = "txtVideoTitle";
            this.txtVideoTitle.Size = new System.Drawing.Size(53, 12);
            this.txtVideoTitle.TabIndex = 4;
            this.txtVideoTitle.Text = "视频名称";
            // 
            // BtnAuto
            // 
            this.BtnAuto.Location = new System.Drawing.Point(32, 219);
            this.BtnAuto.Name = "BtnAuto";
            this.BtnAuto.Size = new System.Drawing.Size(75, 23);
            this.BtnAuto.TabIndex = 5;
            this.BtnAuto.Text = "自动执行";
            this.BtnAuto.UseVisualStyleBackColor = true;
            this.BtnAuto.Click += new System.EventHandler(this.BtnAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 260);
            this.Controls.Add(this.BtnAuto);
            this.Controls.Add(this.txtVideoTitle);
            this.Controls.Add(this.BtnGetVideoUrl);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.TxtVideoUrl);
            this.Controls.Add(this.BtnDownload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDownload;
        private System.Windows.Forms.TextBox TxtVideoUrl;
        private System.Windows.Forms.RichTextBox TxtResult;
        private System.Windows.Forms.Button BtnGetVideoUrl;
        private System.Windows.Forms.Label txtVideoTitle;
        private System.Windows.Forms.Button BtnAuto;
    }
}

