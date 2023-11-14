using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using static System.Net.WebRequestMethods;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Collections;
using Newtonsoft.Json;
using System.Net.Http;

namespace FuturesNewsSol
{
    public class KoreaSec
    {
        readonly string key = "";
        readonly string secret = "";
        static async void Main()
        {
            string key = "your_app_key";
            string secret = "your_secret_key";

            string approvalKey = GetApproval(key, secret);

            Console.WriteLine($"Approval Key: {approvalKey}");
        }


        static string GetApproval(string key, string secret)
        {
            string url = "https://openapi.koreainvestment.com:9443";
            string path = "oauth2/Approval";
            string apiUrl = $"{url}/{path}";

            using (HttpClient client = new HttpClient())
            {
                // 요청 본문 데이터 설정
                var body = new
                {
                    grant_type = "client_credentials",
                    appkey = key,
                    secretkey = secret
                };

                // JSON 형식의 문자열로 직렬화
                string requestBody = JsonConvert.SerializeObject(body);

                // Content-Type 및 요청 본문 설정
                var content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                // POST 요청 수행
                HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;

                // 응답 확인
                if (response.IsSuccessStatusCode)
                {
                    // 응답 데이터 읽기
                    string responseData = response.Content.ReadAsStringAsync().Result;

                    // 응답 데이터에서 approval_key 추출
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseData);
                    string approvalKey = jsonResponse.approval_key;

                    return approvalKey;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return null;
                }
            }
        }
    }
}
