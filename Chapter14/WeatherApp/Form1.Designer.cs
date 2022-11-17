
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
            this.cbPrefecture = new System.Windows.Forms.ComboBox();
            this.lbArea = new System.Windows.Forms.Label();
            this.lbPresenter = new System.Windows.Forms.Label();
            this.lbReportingDate = new System.Windows.Forms.Label();
            this.lbTodayWeather = new System.Windows.Forms.Label();
            this.lbTomorrowWeather = new System.Windows.Forms.Label();
            this.tbPresenter = new System.Windows.Forms.TextBox();
            this.tbrDate = new System.Windows.Forms.TextBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tbTodayWeather = new System.Windows.Forms.TextBox();
            this.tbTomorrowWeather = new System.Windows.Forms.TextBox();
            this.pbTodayWeather = new System.Windows.Forms.PictureBox();
            this.pbTomorrowWeather = new System.Windows.Forms.PictureBox();
            this.cbRegions = new System.Windows.Forms.ComboBox();
            this.lbTodayMaxTemp = new System.Windows.Forms.Label();
            this.tbTodayMaxTemp = new System.Windows.Forms.TextBox();
            this.lbTodayMinTemp = new System.Windows.Forms.Label();
            this.tbTodayMinTemp = new System.Windows.Forms.TextBox();
            this.tbTrMaxTemp = new System.Windows.Forms.TextBox();
            this.tbTrMinTemp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodayWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrowWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Location = new System.Drawing.Point(123, 364);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(376, 146);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(12, 12);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(104, 45);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(27, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "天気概況";
            // 
            // cbPrefecture
            // 
            this.cbPrefecture.FormattingEnabled = true;
            this.cbPrefecture.Location = new System.Drawing.Point(123, 12);
            this.cbPrefecture.Name = "cbPrefecture";
            this.cbPrefecture.Size = new System.Drawing.Size(176, 20);
            this.cbPrefecture.TabIndex = 3;
            this.cbPrefecture.TextChanged += new System.EventHandler(this.cbPrefecture_TextChanged);
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbArea.Location = new System.Drawing.Point(32, 153);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(85, 19);
            this.lbArea.TabIndex = 2;
            this.lbArea.Text = "対象地域";
            // 
            // lbPresenter
            // 
            this.lbPresenter.AutoSize = true;
            this.lbPresenter.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbPresenter.Location = new System.Drawing.Point(49, 77);
            this.lbPresenter.Name = "lbPresenter";
            this.lbPresenter.Size = new System.Drawing.Size(66, 19);
            this.lbPresenter.TabIndex = 2;
            this.lbPresenter.Text = "発表者";
            // 
            // lbReportingDate
            // 
            this.lbReportingDate.AutoSize = true;
            this.lbReportingDate.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbReportingDate.Location = new System.Drawing.Point(50, 117);
            this.lbReportingDate.Name = "lbReportingDate";
            this.lbReportingDate.Size = new System.Drawing.Size(66, 19);
            this.lbReportingDate.TabIndex = 2;
            this.lbReportingDate.Text = "報告日";
            // 
            // lbTodayWeather
            // 
            this.lbTodayWeather.AutoSize = true;
            this.lbTodayWeather.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTodayWeather.Location = new System.Drawing.Point(16, 191);
            this.lbTodayWeather.Name = "lbTodayWeather";
            this.lbTodayWeather.Size = new System.Drawing.Size(101, 19);
            this.lbTodayWeather.TabIndex = 2;
            this.lbTodayWeather.Text = "今日の天気";
            // 
            // lbTomorrowWeather
            // 
            this.lbTomorrowWeather.AutoSize = true;
            this.lbTomorrowWeather.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTomorrowWeather.Location = new System.Drawing.Point(13, 283);
            this.lbTomorrowWeather.Name = "lbTomorrowWeather";
            this.lbTomorrowWeather.Size = new System.Drawing.Size(101, 19);
            this.lbTomorrowWeather.TabIndex = 2;
            this.lbTomorrowWeather.Text = "明日の天気";
            // 
            // tbPresenter
            // 
            this.tbPresenter.Location = new System.Drawing.Point(123, 71);
            this.tbPresenter.Multiline = true;
            this.tbPresenter.Name = "tbPresenter";
            this.tbPresenter.Size = new System.Drawing.Size(264, 28);
            this.tbPresenter.TabIndex = 0;
            // 
            // tbrDate
            // 
            this.tbrDate.Location = new System.Drawing.Point(123, 111);
            this.tbrDate.Multiline = true;
            this.tbrDate.Name = "tbrDate";
            this.tbrDate.Size = new System.Drawing.Size(263, 27);
            this.tbrDate.TabIndex = 0;
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(123, 147);
            this.tbArea.Multiline = true;
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(264, 28);
            this.tbArea.TabIndex = 0;
            // 
            // tbTodayWeather
            // 
            this.tbTodayWeather.Location = new System.Drawing.Point(124, 187);
            this.tbTodayWeather.Multiline = true;
            this.tbTodayWeather.Name = "tbTodayWeather";
            this.tbTodayWeather.Size = new System.Drawing.Size(263, 27);
            this.tbTodayWeather.TabIndex = 0;
            // 
            // tbTomorrowWeather
            // 
            this.tbTomorrowWeather.Location = new System.Drawing.Point(123, 278);
            this.tbTomorrowWeather.Multiline = true;
            this.tbTomorrowWeather.Name = "tbTomorrowWeather";
            this.tbTomorrowWeather.Size = new System.Drawing.Size(262, 27);
            this.tbTomorrowWeather.TabIndex = 0;
            // 
            // pbTodayWeather
            // 
            this.pbTodayWeather.Location = new System.Drawing.Point(403, 187);
            this.pbTodayWeather.Name = "pbTodayWeather";
            this.pbTodayWeather.Size = new System.Drawing.Size(98, 67);
            this.pbTodayWeather.TabIndex = 4;
            this.pbTodayWeather.TabStop = false;
            // 
            // pbTomorrowWeather
            // 
            this.pbTomorrowWeather.Location = new System.Drawing.Point(403, 278);
            this.pbTomorrowWeather.Name = "pbTomorrowWeather";
            this.pbTomorrowWeather.Size = new System.Drawing.Size(98, 67);
            this.pbTomorrowWeather.TabIndex = 4;
            this.pbTomorrowWeather.TabStop = false;
            // 
            // cbRegions
            // 
            this.cbRegions.FormattingEnabled = true;
            this.cbRegions.Location = new System.Drawing.Point(305, 12);
            this.cbRegions.Name = "cbRegions";
            this.cbRegions.Size = new System.Drawing.Size(181, 20);
            this.cbRegions.TabIndex = 3;
            this.cbRegions.TextChanged += new System.EventHandler(this.cbRegions_TextChanged);
            // 
            // lbTodayMaxTemp
            // 
            this.lbTodayMaxTemp.AutoSize = true;
            this.lbTodayMaxTemp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTodayMaxTemp.Location = new System.Drawing.Point(34, 229);
            this.lbTodayMaxTemp.Name = "lbTodayMaxTemp";
            this.lbTodayMaxTemp.Size = new System.Drawing.Size(85, 19);
            this.lbTodayMaxTemp.TabIndex = 2;
            this.lbTodayMaxTemp.Text = "最高気温";
            // 
            // tbTodayMaxTemp
            // 
            this.tbTodayMaxTemp.Location = new System.Drawing.Point(125, 227);
            this.tbTodayMaxTemp.Multiline = true;
            this.tbTodayMaxTemp.Name = "tbTodayMaxTemp";
            this.tbTodayMaxTemp.Size = new System.Drawing.Size(73, 25);
            this.tbTodayMaxTemp.TabIndex = 0;
            // 
            // lbTodayMinTemp
            // 
            this.lbTodayMinTemp.AutoSize = true;
            this.lbTodayMinTemp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTodayMinTemp.Location = new System.Drawing.Point(221, 229);
            this.lbTodayMinTemp.Name = "lbTodayMinTemp";
            this.lbTodayMinTemp.Size = new System.Drawing.Size(85, 19);
            this.lbTodayMinTemp.TabIndex = 2;
            this.lbTodayMinTemp.Text = "最低気温";
            // 
            // tbTodayMinTemp
            // 
            this.tbTodayMinTemp.Location = new System.Drawing.Point(313, 227);
            this.tbTodayMinTemp.Multiline = true;
            this.tbTodayMinTemp.Name = "tbTodayMinTemp";
            this.tbTodayMinTemp.Size = new System.Drawing.Size(74, 27);
            this.tbTodayMinTemp.TabIndex = 0;
            // 
            // tbTrMaxTemp
            // 
            this.tbTrMaxTemp.Location = new System.Drawing.Point(124, 318);
            this.tbTrMaxTemp.Multiline = true;
            this.tbTrMaxTemp.Name = "tbTrMaxTemp";
            this.tbTrMaxTemp.Size = new System.Drawing.Size(73, 25);
            this.tbTrMaxTemp.TabIndex = 0;
            // 
            // tbTrMinTemp
            // 
            this.tbTrMinTemp.Location = new System.Drawing.Point(312, 318);
            this.tbTrMinTemp.Multiline = true;
            this.tbTrMinTemp.Name = "tbTrMinTemp";
            this.tbTrMinTemp.Size = new System.Drawing.Size(74, 27);
            this.tbTrMinTemp.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(33, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "最高気温";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(221, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "最低気温";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 539);
            this.Controls.Add(this.pbTomorrowWeather);
            this.Controls.Add(this.pbTodayWeather);
            this.Controls.Add(this.cbRegions);
            this.Controls.Add(this.cbPrefecture);
            this.Controls.Add(this.lbPresenter);
            this.Controls.Add(this.lbTomorrowWeather);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTodayMinTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTodayMaxTemp);
            this.Controls.Add(this.lbTodayWeather);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbReportingDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbTomorrowWeather);
            this.Controls.Add(this.tbTrMinTemp);
            this.Controls.Add(this.tbTodayMinTemp);
            this.Controls.Add(this.tbTrMaxTemp);
            this.Controls.Add(this.tbTodayMaxTemp);
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
        private System.Windows.Forms.ComboBox cbPrefecture;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label lbPresenter;
        private System.Windows.Forms.Label lbReportingDate;
        private System.Windows.Forms.Label lbTodayWeather;
        private System.Windows.Forms.Label lbTomorrowWeather;
        private System.Windows.Forms.TextBox tbPresenter;
        private System.Windows.Forms.TextBox tbrDate;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbTodayWeather;
        private System.Windows.Forms.TextBox tbTomorrowWeather;
        private System.Windows.Forms.PictureBox pbTodayWeather;
        private System.Windows.Forms.PictureBox pbTomorrowWeather;
        private System.Windows.Forms.ComboBox cbRegions;
        private System.Windows.Forms.Label lbTodayMaxTemp;
        private System.Windows.Forms.TextBox tbTodayMaxTemp;
        private System.Windows.Forms.Label lbTodayMinTemp;
        private System.Windows.Forms.TextBox tbTodayMinTemp;
        private System.Windows.Forms.TextBox tbTrMaxTemp;
        private System.Windows.Forms.TextBox tbTrMinTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

