using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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

            Stream objStream;
            objStream = webRequest.GetResponse().GetResponseStream();
            
            StreamReader r = new StreamReader(objStream);
            string text = r.ReadToEnd();
            
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
                content = Regex.Replace(content, "<[a-zA-Z/].*?>", String.Empty);
                
                item.SubItems.Add(title);
                item.SubItems.Add(date);
                item.SubItems.Add(ticker);
                contentList.Add(content);

                newsLvw.Items.Add(item);
            }
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

                PapagoTranslate(contentRtx.Text);
            }
        }
        private void PapagoTranslate(string sourceText)
        {
            // 번역문 만들기
            string sUrl = "https://openapi.naver.com/v1/papago/n2mt";

            // 파라미터에 값넣기 (파파고 NMT API 가이드에서 -d 부분이 파라미터이다)
            sourceText = contentRtx.Text;

            string sParam = string.Format($"source=en&target=ko&text={Uri.EscapeDataString(sourceText)}");

            // 파라미터를 Character Set에 맞게 변경
            byte[] bytearry = Encoding.UTF8.GetBytes(sParam);

            // 서버에 요청
            WebRequest webRequest = WebRequest.Create(sUrl);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";

            // 헤더 추가하기 (파파고 NMT API 가이드에서 -h 부분이 헤더이다)
            webRequest.Headers.Add("X-Naver-Client-Id", "");
            webRequest.Headers.Add("X-Naver-Client-Secret", "");

            // 요청 데이터 길이
            webRequest.ContentLength = bytearry.Length;

            Stream stream = webRequest.GetRequestStream();
            stream.Write(bytearry, 0, bytearry.Length);
            stream.Close();

            // 응답 데이터 가져오기(출력포맷)
            WebResponse webResponse = webRequest.GetResponse();
            stream = webResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string sReturn = streamReader.ReadToEnd();

            streamReader.Close();
            stream.Close();
            webResponse.Close();

            JObject jObject = JObject.Parse(sReturn);
            // JSON 출력포맷에서 필요한 부분(번역된 문장)만 가져오기
            contentRtx2.Text = jObject["message"]["result"]["translatedText"].ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // 번역문 만들기
            string sUrl = "https://openapi.naver.com/v1/papago/n2mt";

            // 파라미터에 값넣기 (파파고 NMT API 가이드에서 -d 부분이 파라미터이다)
            string sourceText = contentRtx.Text;
            
            string sParam = string.Format($"source=en&target=ko&text={Uri.EscapeDataString(sourceText)}");

            // 파라미터를 Character Set에 맞게 변경
            byte[] bytearry = Encoding.UTF8.GetBytes(sParam);
 
            // 서버에 요청
            WebRequest webRequest = WebRequest.Create(sUrl);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";

            // 헤더 추가하기 (파파고 NMT API 가이드에서 -h 부분이 헤더이다)
            webRequest.Headers.Add("X-Naver-Client-Id", "");
            webRequest.Headers.Add("X-Naver-Client-Secret", "");

            // 요청 데이터 길이
            webRequest.ContentLength = bytearry.Length;

            Stream stream = webRequest.GetRequestStream();
            stream.Write(bytearry, 0, bytearry.Length);
            stream.Close();

            // 응답 데이터 가져오기(출력포맷)
            WebResponse webResponse = webRequest.GetResponse();
            stream = webResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string sReturn = streamReader.ReadToEnd();

            streamReader.Close();
            stream.Close();
            webResponse.Close();

            JObject jObject = JObject.Parse(sReturn);
            // JSON 출력포맷에서 필요한 부분(번역된 문장)만 가져오기
            contentRtx2.Text = jObject["message"]["result"]["translatedText"].ToString();
            
        }
    }
}
