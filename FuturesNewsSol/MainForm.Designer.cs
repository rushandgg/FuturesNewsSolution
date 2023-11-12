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
            this.newsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.newsListView = new System.Windows.Forms.ListView();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contentRichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newsLoadBtn
            // 
            this.newsLoadBtn.Location = new System.Drawing.Point(329, 195);
            this.newsLoadBtn.Name = "newsLoadBtn";
            this.newsLoadBtn.Size = new System.Drawing.Size(175, 62);
            this.newsLoadBtn.TabIndex = 1;
            this.newsLoadBtn.Text = "NewsLoad";
            this.newsLoadBtn.UseVisualStyleBackColor = true;
            this.newsLoadBtn.Click += new System.EventHandler(this.newsLoadBtn_Click);
            // 
            // newsRichTextBox
            // 
            this.newsRichTextBox.Location = new System.Drawing.Point(12, 319);
            this.newsRichTextBox.Name = "newsRichTextBox";
            this.newsRichTextBox.Size = new System.Drawing.Size(414, 94);
            this.newsRichTextBox.TabIndex = 3;
            this.newsRichTextBox.Text = "";
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Location = new System.Drawing.Point(510, 30);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(414, 290);
            this.contentRichTextBox.TabIndex = 4;
            this.contentRichTextBox.Text = "";
            // 
            // newsListView
            // 
            this.newsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.title,
            this.date,
            this.ticker});
            this.newsListView.FullRowSelect = true;
            this.newsListView.HideSelection = false;
            this.newsListView.LabelWrap = false;
            this.newsListView.Location = new System.Drawing.Point(12, 12);
            this.newsListView.MultiSelect = false;
            this.newsListView.Name = "newsListView";
            this.newsListView.Size = new System.Drawing.Size(492, 177);
            this.newsListView.TabIndex = 5;
            this.newsListView.UseCompatibleStateImageBehavior = false;
            this.newsListView.View = System.Windows.Forms.View.Details;
            this.newsListView.SelectedIndexChanged += new System.EventHandler(this.newsListView_SelectedIndexChanged);
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
            // num
            // 
            this.num.Text = "Num";
            this.num.Width = 40;
            // 
            // contentRichTextBox2
            // 
            this.contentRichTextBox2.Location = new System.Drawing.Point(510, 347);
            this.contentRichTextBox2.Name = "contentRichTextBox2";
            this.contentRichTextBox2.Size = new System.Drawing.Size(414, 290);
            this.contentRichTextBox2.TabIndex = 6;
            this.contentRichTextBox2.Text = "";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "NewsLoad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 680);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contentRichTextBox2);
            this.Controls.Add(this.newsListView);
            this.Controls.Add(this.contentRichTextBox);
            this.Controls.Add(this.newsRichTextBox);
            this.Controls.Add(this.newsLoadBtn);
            this.Name = "MainForm";
            this.Text = "FuturesNewsSol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newsLoadBtn;
        private System.Windows.Forms.RichTextBox newsRichTextBox;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
        private System.Windows.Forms.ListView newsListView;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader ticker;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.RichTextBox contentRichTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

