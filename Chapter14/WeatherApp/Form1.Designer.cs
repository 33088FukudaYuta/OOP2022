﻿
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
            this.lbWeekWeather = new System.Windows.Forms.Label();
            this.lbToday = new System.Windows.Forms.Label();
            this.tbTodayTemp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbOneDayLater = new System.Windows.Forms.Label();
            this.tbOneDayLaterTemp = new System.Windows.Forms.TextBox();
            this.lbTwoDayLater = new System.Windows.Forms.Label();
            this.lbThreeDayLater = new System.Windows.Forms.Label();
            this.lbFourDayLater = new System.Windows.Forms.Label();
            this.lbFiveDayLater = new System.Windows.Forms.Label();
            this.lbSixDayLater = new System.Windows.Forms.Label();
            this.tbTwoDayLaterTemp = new System.Windows.Forms.TextBox();
            this.tbThreeDayLaterTemp = new System.Windows.Forms.TextBox();
            this.tbFourDayLaterTemp = new System.Windows.Forms.TextBox();
            this.tbFiveDayLaterTemp = new System.Windows.Forms.TextBox();
            this.tbSixDayLaterTemp = new System.Windows.Forms.TextBox();
            this.pbToday = new System.Windows.Forms.PictureBox();
            this.pbOneDayLater = new System.Windows.Forms.PictureBox();
            this.pbTwoDayLater = new System.Windows.Forms.PictureBox();
            this.lbOneDay = new System.Windows.Forms.Label();
            this.lbTodayTemp = new System.Windows.Forms.Label();
            this.pbThreeDayLater = new System.Windows.Forms.PictureBox();
            this.pbFourDayLater = new System.Windows.Forms.PictureBox();
            this.pbFiveDayLater = new System.Windows.Forms.PictureBox();
            this.pbSixDayLater = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodayWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrowWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOneDayLater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwoDayLater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThreeDayLater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFourDayLater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiveDayLater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSixDayLater)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherInfo.Location = new System.Drawing.Point(123, 385);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(380, 192);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
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
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(27, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "天気概況";
            // 
            // cbPrefecture
            // 
            this.cbPrefecture.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbPrefecture.FormattingEnabled = true;
            this.cbPrefecture.Location = new System.Drawing.Point(123, 12);
            this.cbPrefecture.Name = "cbPrefecture";
            this.cbPrefecture.Size = new System.Drawing.Size(203, 21);
            this.cbPrefecture.TabIndex = 3;
            this.cbPrefecture.TextChanged += new System.EventHandler(this.cbPrefecture_TextChanged);
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbArea.Location = new System.Drawing.Point(32, 153);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(89, 19);
            this.lbArea.TabIndex = 2;
            this.lbArea.Text = "対象地域";
            // 
            // lbPresenter
            // 
            this.lbPresenter.AutoSize = true;
            this.lbPresenter.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbPresenter.Location = new System.Drawing.Point(49, 77);
            this.lbPresenter.Name = "lbPresenter";
            this.lbPresenter.Size = new System.Drawing.Size(69, 19);
            this.lbPresenter.TabIndex = 2;
            this.lbPresenter.Text = "発表者";
            // 
            // lbReportingDate
            // 
            this.lbReportingDate.AutoSize = true;
            this.lbReportingDate.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbReportingDate.Location = new System.Drawing.Point(50, 117);
            this.lbReportingDate.Name = "lbReportingDate";
            this.lbReportingDate.Size = new System.Drawing.Size(69, 19);
            this.lbReportingDate.TabIndex = 2;
            this.lbReportingDate.Text = "報告日";
            // 
            // lbTodayWeather
            // 
            this.lbTodayWeather.AutoSize = true;
            this.lbTodayWeather.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTodayWeather.Location = new System.Drawing.Point(16, 191);
            this.lbTodayWeather.Name = "lbTodayWeather";
            this.lbTodayWeather.Size = new System.Drawing.Size(106, 19);
            this.lbTodayWeather.TabIndex = 2;
            this.lbTodayWeather.Text = "今日の天気";
            // 
            // lbTomorrowWeather
            // 
            this.lbTomorrowWeather.AutoSize = true;
            this.lbTomorrowWeather.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTomorrowWeather.Location = new System.Drawing.Point(15, 296);
            this.lbTomorrowWeather.Name = "lbTomorrowWeather";
            this.lbTomorrowWeather.Size = new System.Drawing.Size(106, 19);
            this.lbTomorrowWeather.TabIndex = 2;
            this.lbTomorrowWeather.Text = "明日の天気";
            // 
            // tbPresenter
            // 
            this.tbPresenter.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbPresenter.Location = new System.Drawing.Point(123, 71);
            this.tbPresenter.Multiline = true;
            this.tbPresenter.Name = "tbPresenter";
            this.tbPresenter.Size = new System.Drawing.Size(264, 28);
            this.tbPresenter.TabIndex = 0;
            // 
            // tbrDate
            // 
            this.tbrDate.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbrDate.Location = new System.Drawing.Point(123, 111);
            this.tbrDate.Multiline = true;
            this.tbrDate.Name = "tbrDate";
            this.tbrDate.Size = new System.Drawing.Size(263, 27);
            this.tbrDate.TabIndex = 0;
            // 
            // tbArea
            // 
            this.tbArea.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbArea.Location = new System.Drawing.Point(123, 147);
            this.tbArea.Multiline = true;
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(264, 28);
            this.tbArea.TabIndex = 0;
            // 
            // tbTodayWeather
            // 
            this.tbTodayWeather.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTodayWeather.Location = new System.Drawing.Point(124, 187);
            this.tbTodayWeather.Multiline = true;
            this.tbTodayWeather.Name = "tbTodayWeather";
            this.tbTodayWeather.Size = new System.Drawing.Size(263, 49);
            this.tbTodayWeather.TabIndex = 0;
            // 
            // tbTomorrowWeather
            // 
            this.tbTomorrowWeather.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTomorrowWeather.Location = new System.Drawing.Point(125, 291);
            this.tbTomorrowWeather.Multiline = true;
            this.tbTomorrowWeather.Name = "tbTomorrowWeather";
            this.tbTomorrowWeather.Size = new System.Drawing.Size(262, 47);
            this.tbTomorrowWeather.TabIndex = 0;
            // 
            // pbTodayWeather
            // 
            this.pbTodayWeather.Location = new System.Drawing.Point(403, 187);
            this.pbTodayWeather.Name = "pbTodayWeather";
            this.pbTodayWeather.Size = new System.Drawing.Size(98, 80);
            this.pbTodayWeather.TabIndex = 4;
            this.pbTodayWeather.TabStop = false;
            // 
            // pbTomorrowWeather
            // 
            this.pbTomorrowWeather.Location = new System.Drawing.Point(405, 291);
            this.pbTomorrowWeather.Name = "pbTomorrowWeather";
            this.pbTomorrowWeather.Size = new System.Drawing.Size(98, 80);
            this.pbTomorrowWeather.TabIndex = 4;
            this.pbTomorrowWeather.TabStop = false;
            // 
            // cbRegions
            // 
            this.cbRegions.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbRegions.FormattingEnabled = true;
            this.cbRegions.Location = new System.Drawing.Point(332, 12);
            this.cbRegions.Name = "cbRegions";
            this.cbRegions.Size = new System.Drawing.Size(169, 21);
            this.cbRegions.TabIndex = 3;
            this.cbRegions.TextChanged += new System.EventHandler(this.cbRegions_TextChanged);
            // 
            // lbTodayMaxTemp
            // 
            this.lbTodayMaxTemp.AutoSize = true;
            this.lbTodayMaxTemp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTodayMaxTemp.Location = new System.Drawing.Point(31, 245);
            this.lbTodayMaxTemp.Name = "lbTodayMaxTemp";
            this.lbTodayMaxTemp.Size = new System.Drawing.Size(89, 19);
            this.lbTodayMaxTemp.TabIndex = 2;
            this.lbTodayMaxTemp.Text = "最高気温";
            // 
            // tbTodayMaxTemp
            // 
            this.tbTodayMaxTemp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTodayMaxTemp.Location = new System.Drawing.Point(125, 242);
            this.tbTodayMaxTemp.Multiline = true;
            this.tbTodayMaxTemp.Name = "tbTodayMaxTemp";
            this.tbTodayMaxTemp.Size = new System.Drawing.Size(73, 25);
            this.tbTodayMaxTemp.TabIndex = 0;
            // 
            // lbTodayMinTemp
            // 
            this.lbTodayMinTemp.AutoSize = true;
            this.lbTodayMinTemp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTodayMinTemp.Location = new System.Drawing.Point(221, 244);
            this.lbTodayMinTemp.Name = "lbTodayMinTemp";
            this.lbTodayMinTemp.Size = new System.Drawing.Size(89, 19);
            this.lbTodayMinTemp.TabIndex = 2;
            this.lbTodayMinTemp.Text = "最低気温";
            // 
            // tbTodayMinTemp
            // 
            this.tbTodayMinTemp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTodayMinTemp.Location = new System.Drawing.Point(313, 242);
            this.tbTodayMinTemp.Multiline = true;
            this.tbTodayMinTemp.Name = "tbTodayMinTemp";
            this.tbTodayMinTemp.Size = new System.Drawing.Size(74, 27);
            this.tbTodayMinTemp.TabIndex = 0;
            // 
            // tbTrMaxTemp
            // 
            this.tbTrMaxTemp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTrMaxTemp.Location = new System.Drawing.Point(124, 344);
            this.tbTrMaxTemp.Multiline = true;
            this.tbTrMaxTemp.Name = "tbTrMaxTemp";
            this.tbTrMaxTemp.Size = new System.Drawing.Size(73, 25);
            this.tbTrMaxTemp.TabIndex = 0;
            // 
            // tbTrMinTemp
            // 
            this.tbTrMinTemp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTrMinTemp.Location = new System.Drawing.Point(312, 344);
            this.tbTrMinTemp.Multiline = true;
            this.tbTrMinTemp.Name = "tbTrMinTemp";
            this.tbTrMinTemp.Size = new System.Drawing.Size(74, 27);
            this.tbTrMinTemp.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(33, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "最高気温";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(221, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "最低気温";
            // 
            // lbWeekWeather
            // 
            this.lbWeekWeather.AutoSize = true;
            this.lbWeekWeather.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbWeekWeather.Location = new System.Drawing.Point(656, 15);
            this.lbWeekWeather.Name = "lbWeekWeather";
            this.lbWeekWeather.Size = new System.Drawing.Size(214, 27);
            this.lbWeekWeather.TabIndex = 5;
            this.lbWeekWeather.Text = "１週間の天気予報";
            // 
            // lbToday
            // 
            this.lbToday.AutoSize = true;
            this.lbToday.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbToday.Location = new System.Drawing.Point(560, 79);
            this.lbToday.Name = "lbToday";
            this.lbToday.Size = new System.Drawing.Size(0, 27);
            this.lbToday.TabIndex = 5;
            // 
            // tbTodayTemp
            // 
            this.tbTodayTemp.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTodayTemp.Location = new System.Drawing.Point(694, 76);
            this.tbTodayTemp.Multiline = true;
            this.tbTodayTemp.Name = "tbTodayTemp";
            this.tbTodayTemp.Size = new System.Drawing.Size(131, 42);
            this.tbTodayTemp.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(673, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "最高気温 / 最低気温";
            // 
            // lbOneDayLater
            // 
            this.lbOneDayLater.AutoSize = true;
            this.lbOneDayLater.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbOneDayLater.Location = new System.Drawing.Point(560, 139);
            this.lbOneDayLater.Name = "lbOneDayLater";
            this.lbOneDayLater.Size = new System.Drawing.Size(0, 27);
            this.lbOneDayLater.TabIndex = 5;
            // 
            // tbOneDayLaterTemp
            // 
            this.tbOneDayLaterTemp.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbOneDayLaterTemp.Location = new System.Drawing.Point(694, 139);
            this.tbOneDayLaterTemp.Multiline = true;
            this.tbOneDayLaterTemp.Name = "tbOneDayLaterTemp";
            this.tbOneDayLaterTemp.Size = new System.Drawing.Size(131, 46);
            this.tbOneDayLaterTemp.TabIndex = 6;
            // 
            // lbTwoDayLater
            // 
            this.lbTwoDayLater.AutoSize = true;
            this.lbTwoDayLater.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTwoDayLater.Location = new System.Drawing.Point(562, 220);
            this.lbTwoDayLater.Name = "lbTwoDayLater";
            this.lbTwoDayLater.Size = new System.Drawing.Size(66, 27);
            this.lbTwoDayLater.TabIndex = 5;
            this.lbTwoDayLater.Text = "今日";
            // 
            // lbThreeDayLater
            // 
            this.lbThreeDayLater.AutoSize = true;
            this.lbThreeDayLater.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbThreeDayLater.Location = new System.Drawing.Point(560, 291);
            this.lbThreeDayLater.Name = "lbThreeDayLater";
            this.lbThreeDayLater.Size = new System.Drawing.Size(66, 27);
            this.lbThreeDayLater.TabIndex = 5;
            this.lbThreeDayLater.Text = "今日";
            // 
            // lbFourDayLater
            // 
            this.lbFourDayLater.AutoSize = true;
            this.lbFourDayLater.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFourDayLater.Location = new System.Drawing.Point(560, 359);
            this.lbFourDayLater.Name = "lbFourDayLater";
            this.lbFourDayLater.Size = new System.Drawing.Size(66, 27);
            this.lbFourDayLater.TabIndex = 5;
            this.lbFourDayLater.Text = "今日";
            // 
            // lbFiveDayLater
            // 
            this.lbFiveDayLater.AutoSize = true;
            this.lbFiveDayLater.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFiveDayLater.Location = new System.Drawing.Point(560, 426);
            this.lbFiveDayLater.Name = "lbFiveDayLater";
            this.lbFiveDayLater.Size = new System.Drawing.Size(66, 27);
            this.lbFiveDayLater.TabIndex = 5;
            this.lbFiveDayLater.Text = "今日";
            // 
            // lbSixDayLater
            // 
            this.lbSixDayLater.AutoSize = true;
            this.lbSixDayLater.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbSixDayLater.Location = new System.Drawing.Point(560, 499);
            this.lbSixDayLater.Name = "lbSixDayLater";
            this.lbSixDayLater.Size = new System.Drawing.Size(66, 27);
            this.lbSixDayLater.TabIndex = 5;
            this.lbSixDayLater.Text = "今日";
            // 
            // tbTwoDayLaterTemp
            // 
            this.tbTwoDayLaterTemp.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTwoDayLaterTemp.Location = new System.Drawing.Point(693, 206);
            this.tbTwoDayLaterTemp.Multiline = true;
            this.tbTwoDayLaterTemp.Name = "tbTwoDayLaterTemp";
            this.tbTwoDayLaterTemp.Size = new System.Drawing.Size(131, 48);
            this.tbTwoDayLaterTemp.TabIndex = 6;
            // 
            // tbThreeDayLaterTemp
            // 
            this.tbThreeDayLaterTemp.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbThreeDayLaterTemp.Location = new System.Drawing.Point(694, 277);
            this.tbThreeDayLaterTemp.Multiline = true;
            this.tbThreeDayLaterTemp.Name = "tbThreeDayLaterTemp";
            this.tbThreeDayLaterTemp.Size = new System.Drawing.Size(131, 48);
            this.tbThreeDayLaterTemp.TabIndex = 6;
            // 
            // tbFourDayLaterTemp
            // 
            this.tbFourDayLaterTemp.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFourDayLaterTemp.Location = new System.Drawing.Point(694, 346);
            this.tbFourDayLaterTemp.Multiline = true;
            this.tbFourDayLaterTemp.Name = "tbFourDayLaterTemp";
            this.tbFourDayLaterTemp.Size = new System.Drawing.Size(131, 48);
            this.tbFourDayLaterTemp.TabIndex = 6;
            // 
            // tbFiveDayLaterTemp
            // 
            this.tbFiveDayLaterTemp.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFiveDayLaterTemp.Location = new System.Drawing.Point(693, 415);
            this.tbFiveDayLaterTemp.Multiline = true;
            this.tbFiveDayLaterTemp.Name = "tbFiveDayLaterTemp";
            this.tbFiveDayLaterTemp.Size = new System.Drawing.Size(131, 48);
            this.tbFiveDayLaterTemp.TabIndex = 6;
            // 
            // tbSixDayLaterTemp
            // 
            this.tbSixDayLaterTemp.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSixDayLaterTemp.Location = new System.Drawing.Point(694, 489);
            this.tbSixDayLaterTemp.Multiline = true;
            this.tbSixDayLaterTemp.Name = "tbSixDayLaterTemp";
            this.tbSixDayLaterTemp.Size = new System.Drawing.Size(131, 48);
            this.tbSixDayLaterTemp.TabIndex = 6;
            // 
            // pbToday
            // 
            this.pbToday.Location = new System.Drawing.Point(844, 61);
            this.pbToday.Name = "pbToday";
            this.pbToday.Size = new System.Drawing.Size(98, 62);
            this.pbToday.TabIndex = 4;
            this.pbToday.TabStop = false;
            // 
            // pbOneDayLater
            // 
            this.pbOneDayLater.Location = new System.Drawing.Point(844, 128);
            this.pbOneDayLater.Name = "pbOneDayLater";
            this.pbOneDayLater.Size = new System.Drawing.Size(98, 66);
            this.pbOneDayLater.TabIndex = 4;
            this.pbOneDayLater.TabStop = false;
            // 
            // pbTwoDayLater
            // 
            this.pbTwoDayLater.Location = new System.Drawing.Point(844, 199);
            this.pbTwoDayLater.Name = "pbTwoDayLater";
            this.pbTwoDayLater.Size = new System.Drawing.Size(98, 64);
            this.pbTwoDayLater.TabIndex = 4;
            this.pbTwoDayLater.TabStop = false;
            // 
            // lbOneDay
            // 
            this.lbOneDay.AutoSize = true;
            this.lbOneDay.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbOneDay.Location = new System.Drawing.Point(562, 151);
            this.lbOneDay.Name = "lbOneDay";
            this.lbOneDay.Size = new System.Drawing.Size(66, 27);
            this.lbOneDay.TabIndex = 5;
            this.lbOneDay.Text = "今日";
            // 
            // lbTodayTemp
            // 
            this.lbTodayTemp.AutoSize = true;
            this.lbTodayTemp.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTodayTemp.Location = new System.Drawing.Point(562, 88);
            this.lbTodayTemp.Name = "lbTodayTemp";
            this.lbTodayTemp.Size = new System.Drawing.Size(66, 27);
            this.lbTodayTemp.TabIndex = 5;
            this.lbTodayTemp.Text = "今日";
            // 
            // pbThreeDayLater
            // 
            this.pbThreeDayLater.Location = new System.Drawing.Point(843, 267);
            this.pbThreeDayLater.Name = "pbThreeDayLater";
            this.pbThreeDayLater.Size = new System.Drawing.Size(98, 66);
            this.pbThreeDayLater.TabIndex = 4;
            this.pbThreeDayLater.TabStop = false;
            // 
            // pbFourDayLater
            // 
            this.pbFourDayLater.Location = new System.Drawing.Point(843, 339);
            this.pbFourDayLater.Name = "pbFourDayLater";
            this.pbFourDayLater.Size = new System.Drawing.Size(98, 65);
            this.pbFourDayLater.TabIndex = 4;
            this.pbFourDayLater.TabStop = false;
            // 
            // pbFiveDayLater
            // 
            this.pbFiveDayLater.Location = new System.Drawing.Point(844, 408);
            this.pbFiveDayLater.Name = "pbFiveDayLater";
            this.pbFiveDayLater.Size = new System.Drawing.Size(98, 65);
            this.pbFiveDayLater.TabIndex = 4;
            this.pbFiveDayLater.TabStop = false;
            // 
            // pbSixDayLater
            // 
            this.pbSixDayLater.Location = new System.Drawing.Point(844, 479);
            this.pbSixDayLater.Name = "pbSixDayLater";
            this.pbSixDayLater.Size = new System.Drawing.Size(98, 67);
            this.pbSixDayLater.TabIndex = 4;
            this.pbSixDayLater.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(986, 590);
            this.Controls.Add(this.tbSixDayLaterTemp);
            this.Controls.Add(this.tbFiveDayLaterTemp);
            this.Controls.Add(this.tbFourDayLaterTemp);
            this.Controls.Add(this.tbThreeDayLaterTemp);
            this.Controls.Add(this.tbTwoDayLaterTemp);
            this.Controls.Add(this.tbOneDayLaterTemp);
            this.Controls.Add(this.lbSixDayLater);
            this.Controls.Add(this.lbFiveDayLater);
            this.Controls.Add(this.lbFourDayLater);
            this.Controls.Add(this.lbThreeDayLater);
            this.Controls.Add(this.lbTodayTemp);
            this.Controls.Add(this.lbOneDay);
            this.Controls.Add(this.lbTwoDayLater);
            this.Controls.Add(this.lbOneDayLater);
            this.Controls.Add(this.tbTodayTemp);
            this.Controls.Add(this.lbToday);
            this.Controls.Add(this.lbWeekWeather);
            this.Controls.Add(this.pbTomorrowWeather);
            this.Controls.Add(this.pbSixDayLater);
            this.Controls.Add(this.pbFiveDayLater);
            this.Controls.Add(this.pbFourDayLater);
            this.Controls.Add(this.pbThreeDayLater);
            this.Controls.Add(this.pbTwoDayLater);
            this.Controls.Add(this.pbOneDayLater);
            this.Controls.Add(this.pbToday);
            this.Controls.Add(this.pbTodayWeather);
            this.Controls.Add(this.cbRegions);
            this.Controls.Add(this.cbPrefecture);
            this.Controls.Add(this.lbPresenter);
            this.Controls.Add(this.lbTomorrowWeather);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTodayMinTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOneDayLater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwoDayLater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThreeDayLater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFourDayLater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiveDayLater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSixDayLater)).EndInit();
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
        private System.Windows.Forms.Label lbWeekWeather;
        private System.Windows.Forms.Label lbToday;
        private System.Windows.Forms.TextBox tbTodayTemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbOneDayLater;
        private System.Windows.Forms.TextBox tbOneDayLaterTemp;
        private System.Windows.Forms.Label lbTwoDayLater;
        private System.Windows.Forms.Label lbThreeDayLater;
        private System.Windows.Forms.Label lbFourDayLater;
        private System.Windows.Forms.Label lbFiveDayLater;
        private System.Windows.Forms.Label lbSixDayLater;
        private System.Windows.Forms.TextBox tbTwoDayLaterTemp;
        private System.Windows.Forms.TextBox tbThreeDayLaterTemp;
        private System.Windows.Forms.TextBox tbFourDayLaterTemp;
        private System.Windows.Forms.TextBox tbFiveDayLaterTemp;
        private System.Windows.Forms.TextBox tbSixDayLaterTemp;
        private System.Windows.Forms.PictureBox pbToday;
        private System.Windows.Forms.PictureBox pbOneDayLater;
        private System.Windows.Forms.PictureBox pbTwoDayLater;
        private System.Windows.Forms.Label lbOneDay;
        private System.Windows.Forms.Label lbTodayTemp;
        private System.Windows.Forms.PictureBox pbThreeDayLater;
        private System.Windows.Forms.PictureBox pbFourDayLater;
        private System.Windows.Forms.PictureBox pbFiveDayLater;
        private System.Windows.Forms.PictureBox pbSixDayLater;
    }
}

