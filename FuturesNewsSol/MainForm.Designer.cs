namespace FuturesNewsSol
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.newsLoadBtn = new System.Windows.Forms.Button();
            this.newsRtx = new System.Windows.Forms.RichTextBox();
            this.contentRtx = new System.Windows.Forms.RichTextBox();
            this.newsLvw = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contentRtx2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.translateBtn = new System.Windows.Forms.Button();
            this.min1Btn = new System.Windows.Forms.Button();
            this.min3Btn = new System.Windows.Forms.Button();
            this.min5Btn = new System.Windows.Forms.Button();
            this.min15Btn = new System.Windows.Forms.Button();
            this.min30Btn = new System.Windows.Forms.Button();
            this.min60Btn = new System.Windows.Forms.Button();
            this.comTypeCmb = new System.Windows.Forms.ComboBox();
            this.tickerTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newsLoadBtn
            // 
            this.newsLoadBtn.Location = new System.Drawing.Point(329, 237);
            this.newsLoadBtn.Name = "newsLoadBtn";
            this.newsLoadBtn.Size = new System.Drawing.Size(175, 62);
            this.newsLoadBtn.TabIndex = 1;
            this.newsLoadBtn.Text = "NewsLoad";
            this.newsLoadBtn.UseVisualStyleBackColor = true;
            this.newsLoadBtn.Click += new System.EventHandler(this.newsLoadBtn_Click);
            // 
            // newsRtx
            // 
            this.newsRtx.Location = new System.Drawing.Point(12, 347);
            this.newsRtx.Name = "newsRtx";
            this.newsRtx.Size = new System.Drawing.Size(414, 94);
            this.newsRtx.TabIndex = 3;
            this.newsRtx.Text = "";
            // 
            // contentRtx
            // 
            this.contentRtx.Location = new System.Drawing.Point(510, 30);
            this.contentRtx.Name = "contentRtx";
            this.contentRtx.Size = new System.Drawing.Size(414, 290);
            this.contentRtx.TabIndex = 4;
            this.contentRtx.Text = "";
            // 
            // newsLvw
            // 
            this.newsLvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.title,
            this.date,
            this.ticker});
            this.newsLvw.FullRowSelect = true;
            this.newsLvw.HideSelection = false;
            this.newsLvw.LabelWrap = false;
            this.newsLvw.Location = new System.Drawing.Point(12, 54);
            this.newsLvw.MultiSelect = false;
            this.newsLvw.Name = "newsLvw";
            this.newsLvw.Size = new System.Drawing.Size(492, 177);
            this.newsLvw.TabIndex = 5;
            this.newsLvw.UseCompatibleStateImageBehavior = false;
            this.newsLvw.View = System.Windows.Forms.View.Details;
            this.newsLvw.SelectedIndexChanged += new System.EventHandler(this.newsListView_SelectedIndexChanged);
            // 
            // num
            // 
            this.num.Text = "Num";
            this.num.Width = 40;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 200;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 120;
            // 
            // ticker
            // 
            this.ticker.Text = "Ticker";
            this.ticker.Width = 120;
            // 
            // contentRtx2
            // 
            this.contentRtx2.Location = new System.Drawing.Point(510, 347);
            this.contentRtx2.Name = "contentRtx2";
            this.contentRtx2.Size = new System.Drawing.Size(414, 290);
            this.contentRtx2.TabIndex = 6;
            this.contentRtx2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "원문";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "번역";
            // 
            // translateBtn
            // 
            this.translateBtn.Location = new System.Drawing.Point(329, 463);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(175, 62);
            this.translateBtn.TabIndex = 9;
            this.translateBtn.Text = "Translate";
            this.translateBtn.UseVisualStyleBackColor = true;
            this.translateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // min1Btn
            // 
            this.min1Btn.Location = new System.Drawing.Point(1272, 23);
            this.min1Btn.Margin = new System.Windows.Forms.Padding(0);
            this.min1Btn.Name = "min1Btn";
            this.min1Btn.Size = new System.Drawing.Size(34, 34);
            this.min1Btn.TabIndex = 10;
            this.min1Btn.Text = "1";
            this.min1Btn.UseVisualStyleBackColor = true;
            // 
            // min3Btn
            // 
            this.min3Btn.Location = new System.Drawing.Point(1306, 23);
            this.min3Btn.Margin = new System.Windows.Forms.Padding(0);
            this.min3Btn.Name = "min3Btn";
            this.min3Btn.Size = new System.Drawing.Size(34, 34);
            this.min3Btn.TabIndex = 11;
            this.min3Btn.Text = "3";
            this.min3Btn.UseVisualStyleBackColor = true;
            // 
            // min5Btn
            // 
            this.min5Btn.Location = new System.Drawing.Point(1340, 23);
            this.min5Btn.Margin = new System.Windows.Forms.Padding(0);
            this.min5Btn.Name = "min5Btn";
            this.min5Btn.Size = new System.Drawing.Size(34, 34);
            this.min5Btn.TabIndex = 12;
            this.min5Btn.Text = "5";
            this.min5Btn.UseVisualStyleBackColor = true;
            // 
            // min15Btn
            // 
            this.min15Btn.Location = new System.Drawing.Point(1374, 23);
            this.min15Btn.Margin = new System.Windows.Forms.Padding(0);
            this.min15Btn.Name = "min15Btn";
            this.min15Btn.Size = new System.Drawing.Size(34, 34);
            this.min15Btn.TabIndex = 13;
            this.min15Btn.Text = "15";
            this.min15Btn.UseVisualStyleBackColor = true;
            // 
            // min30Btn
            // 
            this.min30Btn.Location = new System.Drawing.Point(1408, 23);
            this.min30Btn.Margin = new System.Windows.Forms.Padding(0);
            this.min30Btn.Name = "min30Btn";
            this.min30Btn.Size = new System.Drawing.Size(34, 34);
            this.min30Btn.TabIndex = 14;
            this.min30Btn.Text = "30";
            this.min30Btn.UseVisualStyleBackColor = true;
            // 
            // min60Btn
            // 
            this.min60Btn.Location = new System.Drawing.Point(1442, 23);
            this.min60Btn.Margin = new System.Windows.Forms.Padding(0);
            this.min60Btn.Name = "min60Btn";
            this.min60Btn.Size = new System.Drawing.Size(34, 34);
            this.min60Btn.TabIndex = 15;
            this.min60Btn.Text = "60";
            this.min60Btn.UseVisualStyleBackColor = true;
            // 
            // comTypeCmb
            // 
            this.comTypeCmb.FormattingEnabled = true;
            this.comTypeCmb.Location = new System.Drawing.Point(1006, 30);
            this.comTypeCmb.Name = "comTypeCmb";
            this.comTypeCmb.Size = new System.Drawing.Size(121, 23);
            this.comTypeCmb.TabIndex = 16;
            // 
            // tickerTxt
            // 
            this.tickerTxt.Location = new System.Drawing.Point(1149, 30);
            this.tickerTxt.Name = "tickerTxt";
            this.tickerTxt.Size = new System.Drawing.Size(96, 25);
            this.tickerTxt.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 646);
            this.Controls.Add(this.tickerTxt);
            this.Controls.Add(this.comTypeCmb);
            this.Controls.Add(this.min60Btn);
            this.Controls.Add(this.min30Btn);
            this.Controls.Add(this.min15Btn);
            this.Controls.Add(this.min5Btn);
            this.Controls.Add(this.min3Btn);
            this.Controls.Add(this.min1Btn);
            this.Controls.Add(this.translateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contentRtx2);
            this.Controls.Add(this.newsLvw);
            this.Controls.Add(this.contentRtx);
            this.Controls.Add(this.newsRtx);
            this.Controls.Add(this.newsLoadBtn);
            this.Name = "MainForm";
            this.Text = "FuturesNewsSol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newsLoadBtn;
        private System.Windows.Forms.RichTextBox newsRtx;
        private System.Windows.Forms.RichTextBox contentRtx;
        private System.Windows.Forms.ListView newsLvw;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader ticker;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.RichTextBox contentRtx2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button translateBtn;
        private System.Windows.Forms.Button min1Btn;
        private System.Windows.Forms.Button min3Btn;
        private System.Windows.Forms.Button min5Btn;
        private System.Windows.Forms.Button min15Btn;
        private System.Windows.Forms.Button min30Btn;
        private System.Windows.Forms.Button min60Btn;
        private System.Windows.Forms.ComboBox comTypeCmb;
        private System.Windows.Forms.TextBox tickerTxt;
    }
}

