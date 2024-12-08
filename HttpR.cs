using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json.Linq;

namespace FirstTry
{
    internal class HttpR
    {
       public async void SendHttp(System.Windows.Forms.TextBox inputs)
        {
            string url = "http://127.0.0.1:8080/test";
            string jsonContent = JsonConvert.SerializeObject(new { name = inputs.Text }); //Тут отправляю jsonContent типо name = 

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                using (StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json"))
                {
                    HttpResponseMessage response = await client.PostAsync(url, content); //Получаю ответ


                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync(); //преобразование
                        MessageBox.Show("Запрос успешно отправлен. Ответ сервера: " + responseString);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при отправке запроса. Статус код: " + response.StatusCode);
                    }
                }
            }
        } //
        public static string GetValueFromJson(string jsonString, string key)
        {
            JObject json = JObject.Parse(jsonString);
            return (string)json[key];
        }
        public async Task<String> SendHttpS(System.Windows.Forms.TextBox inputs, String key)
        {
            string url = "http://127.0.0.1:8080/test";
            string jsonContent = JsonConvert.SerializeObject(new { name = inputs.Text }); //Тут отправляю jsonContent типо name = 

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                using (StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json"))
                {
                    HttpResponseMessage response = await client.PostAsync(url, content); //Получаю ответ


                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync(); //преобразование
                        string res = GetValueFromJson(responseString, key);
                        return res;
                    }
                    else
                    {
                        return "не удалось отправить запрос";
                    }
                }
            }
        } //


    }
    
}
