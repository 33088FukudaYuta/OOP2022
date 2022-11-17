
namespace WeatherApp {
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
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.lbArea = new System.Windows.Forms.Label();
            this.lbPresenter = new System.Windows.Forms.Label();
            this.lbReportingDate = new System.Windows.Forms.Label();
            this.lbTodayWeather = new System.Windows.Forms.Label();
            this.lbTomorrowWeather = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPresenter = new System.Windows.Forms.TextBox();
            this.tbrDate = new System.Windows.Forms.TextBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tbTodayWeather = new System.Windows.Forms.TextBox();
            this.tbTomorrowWeather = new System.Windows.Forms.TextBox();
            this.pbTodayWeather = new System.Windows.Forms.PictureBox();
            this.pbTomorrowWeather = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodayWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrowWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Location = new System.Drawing.Point(180, 334);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(376, 104);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(12, 12);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(162, 60);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(53, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "天気概況";
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(181, 12);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(209, 20);
            this.cbArea.TabIndex = 3;
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbArea.Location = new System.Drawing.Point(54, 177);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(120, 27);
            this.lbArea.TabIndex = 2;
            this.lbArea.Text = "対象地域";
            // 
            // lbPresenter
            // 
            this.lbPresenter.AutoSize = true;
            this.lbPresenter.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbPresenter.Location = new System.Drawing.Point(80, 87);
            this.lbPresenter.Name = "lbPresenter";
            this.lbPresenter.Size = new System.Drawing.Size(93, 27);
            this.lbPresenter.TabIndex = 2;
            this.lbPresenter.Text = "発表者";
            // 
            // lbReportingDate
            // 
            this.lbReportingDate.AutoSize = true;
            this.lbReportingDate.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbReportingDate.Location = new System.Drawing.Point(81, 133);
            this.lbReportingDate.Name = "lbReportingDate";
            this.lbReportingDate.Size = new System.Drawing.Size(93, 27);
            this.lbReportingDate.TabIndex = 2;
            this.lbReportingDate.Text = "報告日";
            // 
            // lbTodayWeather
            // 
            this.lbTodayWeather.AutoSize = true;
            this.lbTodayWeather.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTodayWeather.Location = new System.Drawing.Point(32, 226);
            this.lbTodayWeather.Name = "lbTodayWeather";
            this.lbTodayWeather.Size = new System.Drawing.Size(142, 27);
            this.lbTodayWeather.TabIndex = 2;
            this.lbTodayWeather.Text = "今日の天気";
            // 
            // lbTomorrowWeather
            // 
            this.lbTomorrowWeather.AutoSize = true;
            this.lbTomorrowWeather.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTomorrowWeather.Location = new System.Drawing.Point(32, 283);
            this.lbTomorrowWeather.Name = "lbTomorrowWeather";
            this.lbTomorrowWeather.Size = new System.Drawing.Size(142, 27);
            this.lbTomorrowWeather.TabIndex = 2;
            this.lbTomorrowWeather.Text = "明日の天気";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(81, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "報告日";
            // 
            // tbPresenter
            // 
            this.tbPresenter.Location = new System.Drawing.Point(180, 87);
            this.tbPresenter.Multiline = true;
            this.tbPresenter.Name = "tbPresenter";
            this.tbPresenter.Size = new System.Drawing.Size(264, 27);
            this.tbPresenter.TabIndex = 0;
            // 
            // tbrDate
            // 
            this.tbrDate.Location = new System.Drawing.Point(181, 133);
            this.tbrDate.Multiline = true;
            this.tbrDate.Name = "tbrDate";
            this.tbrDate.Size = new System.Drawing.Size(263, 27);
            this.tbrDate.TabIndex = 0;
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(180, 177);
            this.tbArea.Multiline = true;
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(264, 27);
            this.tbArea.TabIndex = 0;
            // 
            // tbTodayWeather
            // 
            this.tbTodayWeather.Location = new System.Drawing.Point(181, 226);
            this.tbTodayWeather.Multiline = true;
            this.tbTodayWeather.Name = "tbTodayWeather";
            this.tbTodayWeather.Size = new System.Drawing.Size(263, 27);
            this.tbTodayWeather.TabIndex = 0;
            // 
            // tbTomorrowWeather
            // 
            this.tbTomorrowWeather.Location = new System.Drawing.Point(182, 283);
            this.tbTomorrowWeather.Multiline = true;
            this.tbTomorrowWeather.Name = "tbTomorrowWeather";
            this.tbTomorrowWeather.Size = new System.Drawing.Size(262, 27);
            this.tbTomorrowWeather.TabIndex = 0;
            // 
            // pbTodayWeather
            // 
            this.pbTodayWeather.Location = new System.Drawing.Point(458, 209);
            this.pbTodayWeather.Name = "pbTodayWeather";
            this.pbTodayWeather.Size = new System.Drawing.Size(98, 56);
            this.pbTodayWeather.TabIndex = 4;
            this.pbTodayWeather.TabStop = false;
            // 
            // pbTomorrowWeather
            // 
            this.pbTomorrowWeather.Location = new System.Drawing.Point(458, 272);
            this.pbTomorrowWeather.Name = "pbTomorrowWeather";
            this.pbTomorrowWeather.Size = new System.Drawing.Size(98, 56);
            this.pbTomorrowWeather.TabIndex = 4;
            this.pbTomorrowWeather.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 524);
            this.Controls.Add(this.pbTomorrowWeather);
            this.Controls.Add(this.pbTodayWeather);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.lbPresenter);
            this.Controls.Add(this.lbTomorrowWeather);
            this.Controls.Add(this.lbTodayWeather);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbReportingDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbTomorrowWeather);
            this.Controls.Add(this.tbTodayWeather);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.tbrDate);
            this.Controls.Add(this.tbPresenter);
            this.Controls.Add(this.tbWeatherInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTodayWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrowWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label lbPresenter;
        private System.Windows.Forms.Label lbReportingDate;
        private System.Windows.Forms.Label lbTodayWeather;
        private System.Windows.Forms.Label lbTomorrowWeather;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPresenter;
        private System.Windows.Forms.TextBox tbrDate;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbTodayWeather;
        private System.Windows.Forms.TextBox tbTomorrowWeather;
        private System.Windows.Forms.PictureBox pbTodayWeather;
        private System.Windows.Forms.PictureBox pbTomorrowWeather;
    }
}

