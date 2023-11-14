using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FuturesNewsSol
{
    public partial class MainForm : Form
    {
        readonly static string apiKey = "";
        List<string> contentList = new List<string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void newsLoadBtn_Click(object sender, EventArgs e)
        {
            // 뉴스 목록인 listview 초기화, 본문 목록인 list 초기화
            newsLvw.Items.Clear();
            contentList.Clear();

            int articlesSize = 2;
            string fmpNewsUrl = $"https://financialmodelingprep.com/api/v3/fmp/articles?page=0&size={articlesSize}&apikey={apiKey}";

            WebRequest webRequest;
            webRequest = WebRequest.Create(fmpNewsUrl);

            Stream stream;
            stream = webRequest.GetResponse().GetResponseStream();
            
            StreamReader streamReader = new StreamReader(stream);
            string text = streamReader.ReadToEnd();
            
            // json 파싱, 불러온 수 만큼 content 인덱스 부여
            JObject jObj = JObject.Parse(text);

            // 전체 기사 개수만큼 반복
            for (int i = 0; i < articlesSize; i++)
            {
                ListViewItem item = new ListViewItem($"{i+1}");
                JToken article = jObj["content"][i];
                string title = article.Value<string>("title");
                string date = article.Value<string>("date");
                string ticker = article.Value<string>("tickers");
                string content = article.Value<string>("content");
                content = Regex.Replace(content, "<[a-zA-Z/].*?>", String.Empty); // 정규식으로 데이터 정제
                
                item.SubItems.Add(title);
                item.SubItems.Add(date);
                item.SubItems.Add(ticker);
                contentList.Add(content);

                newsLvw.Items.Add(item);
            }
            stream.Close();
            streamReader.Close();
        }

        private void newsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Null값일 때 오류 방지
            if (newsLvw.SelectedItems.Count != 0) 
            { 
                // 선택된 항목의 인덱스 가져옴
                int SelectRow = newsLvw.SelectedItems[0].Index;
                // 제목 + 본문
                contentRtx.Text = newsLvw.Items[SelectRow].SubItems[1].Text + "\n\n" + contentList[SelectRow].ToString();

                Papago papago = new Papago();
                contentRtx2.Text = papago.Translate(contentRtx.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
