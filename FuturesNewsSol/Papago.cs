using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FuturesNewsSol
{
    public class Papago
    {
        public string Translate(string sourceText)
        {
            string sUrl = "https://openapi.naver.com/v1/papago/n2mt";

            // 파라미터에 값넣기
            string sParam = string.Format($"source=en&target=ko&text={Uri.EscapeDataString(sourceText)}");

            // 파라미터를 Character Set에 맞게 변경
            byte[] byteArray = Encoding.UTF8.GetBytes(sParam);

            // 서버에 요청
            WebRequest webRequest = WebRequest.Create(sUrl);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";

            // 헤더 추가하기
            webRequest.Headers.Add("X-Naver-Client-Id", "");
            webRequest.Headers.Add("X-Naver-Client-Secret", "");

            webRequest.ContentLength = byteArray.Length;

            Stream stream = webRequest.GetRequestStream();
            stream.Write(byteArray, 0, byteArray.Length);
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
            return jObject["message"]["result"]["translatedText"].ToString();
        }
    }
}
