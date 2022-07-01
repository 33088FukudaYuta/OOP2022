
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
            this.btBack = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.wvBrowser = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).BeginInit();
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
            this.lbRSSTitle.Location = new System.Drawing.Point(12, 52);
            this.lbRSSTitle.Name = "lbRSSTitle";
            this.lbRSSTitle.Size = new System.Drawing.Size(775, 100);
            this.lbRSSTitle.TabIndex = 2;
            this.lbRSSTitle.Click += new System.EventHandler(this.lbRSSTitle_Click);
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBack.Location = new System.Drawing.Point(634, 10);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 36);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "◀";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNext.Location = new System.Drawing.Point(715, 10);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(73, 36);
            this.btNext.TabIndex = 5;
            this.btNext.Text = "▶";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // wvBrowser
            // 
            this.wvBrowser.Location = new System.Drawing.Point(13, 158);
            this.wvBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvBrowser.Name = "wvBrowser";
            this.wvBrowser.Size = new System.Drawing.Size(775, 411);
            this.wvBrowser.TabIndex = 7;
            this.wvBrowser.NavigationCompleted += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs>(this.wvBrowser_NavigationCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.wvBrowser);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lbRSSTitle);
            this.Controls.Add(this.btRSSGet);
            this.Controls.Add(this.cbRSSUrl);
            this.Name = "Form1";
            this.Text = "RSSReader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRSSUrl;
        private System.Windows.Forms.Button btRSSGet;
        private System.Windows.Forms.ListBox lbRSSTitle;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView wvBrowser;
    }
}

