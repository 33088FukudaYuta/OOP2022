
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.cbRSSUrl = new System.Windows.Forms.ComboBox();
            this.btRSSGet = new System.Windows.Forms.Button();
            this.lbRSSTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // cbRSSUrl
            // 
            this.cbRSSUrl.FormattingEnabled = true;
            this.cbRSSUrl.Location = new System.Drawing.Point(13, 13);
            this.cbRSSUrl.Name = "cbRSSUrl";
            this.cbRSSUrl.Size = new System.Drawing.Size(519, 20);
            this.cbRSSUrl.TabIndex = 0;
            // 
            // btRSSGet
            // 
            this.btRSSGet.Location = new System.Drawing.Point(538, 12);
            this.btRSSGet.Name = "btRSSGet";
            this.btRSSGet.Size = new System.Drawing.Size(75, 23);
            this.btRSSGet.TabIndex = 1;
            this.btRSSGet.Text = "取得";
            this.btRSSGet.UseVisualStyleBackColor = true;
            this.btRSSGet.Click += new System.EventHandler(this.btRSSGet_Click);
            // 
            // lbRSSTitle
            // 
            this.lbRSSTitle.FormattingEnabled = true;
            this.lbRSSTitle.ItemHeight = 12;
            this.lbRSSTitle.Location = new System.Drawing.Point(13, 40);
            this.lbRSSTitle.Name = "lbRSSTitle";
            this.lbRSSTitle.Size = new System.Drawing.Size(609, 112);
            this.lbRSSTitle.TabIndex = 2;
            this.lbRSSTitle.Click += new System.EventHandler(this.lbRSSTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(13, 158);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(609, 436);
            this.wbBrowser.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRSSTitle);
            this.Controls.Add(this.btRSSGet);
            this.Controls.Add(this.cbRSSUrl);
            this.Name = "Form1";
            this.Text = "RSSReader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRSSUrl;
        private System.Windows.Forms.Button btRSSGet;
        private System.Windows.Forms.ListBox lbRSSTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
    }
}

