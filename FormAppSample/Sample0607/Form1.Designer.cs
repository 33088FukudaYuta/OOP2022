
namespace Sample0607 {
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
            this.btRandom2 = new System.Windows.Forms.Button();
            this.maxNumber = new System.Windows.Forms.NumericUpDown();
            this.minNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number2)).BeginInit();
            this.SuspendLayout();
            // 
            // btRandom2
            // 
            this.btRandom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btRandom2.Location = new System.Drawing.Point(241, 163);
            this.btRandom2.Name = "btRandom2";
            this.btRandom2.Size = new System.Drawing.Size(119, 64);
            this.btRandom2.TabIndex = 0;
            this.btRandom2.Text = "乱数取得";
            this.btRandom2.UseVisualStyleBackColor = false;
            this.btRandom2.Click += new System.EventHandler(this.btRandom2_Click);
            // 
            // maxNumber
            // 
            this.maxNumber.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maxNumber.Location = new System.Drawing.Point(208, 21);
            this.maxNumber.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.maxNumber.Name = "maxNumber";
            this.maxNumber.Size = new System.Drawing.Size(191, 55);
            this.maxNumber.TabIndex = 1;
            // 
            // minNumber
            // 
            this.minNumber.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minNumber.Location = new System.Drawing.Point(208, 89);
            this.minNumber.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.minNumber.Name = "minNumber";
            this.minNumber.Size = new System.Drawing.Size(191, 55);
            this.minNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "最小値";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "最大値";
            // 
            // Number2
            // 
            this.Number2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number2.Location = new System.Drawing.Point(20, 163);
            this.Number2.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(191, 55);
            this.Number2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 242);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.minNumber);
            this.Controls.Add(this.maxNumber);
            this.Controls.Add(this.btRandom2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "乱数アプリ";
            ((System.ComponentModel.ISupportInitialize)(this.maxNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btRandom2;
        private System.Windows.Forms.NumericUpDown maxNumber;
        private System.Windows.Forms.NumericUpDown minNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Number2;
    }
}

