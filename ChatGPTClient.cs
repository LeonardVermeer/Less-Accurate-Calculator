using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Less_Accurate_Calculator {
    public class ChatGPTClient {
        public static async Task<string> AskAsync(string prompt) {
            string apiKey = Environment.GetEnvironmentVariable("CHATGPT_API_KEY");
            MessageBox.Show(apiKey);

            string endpoint = "https://api.openai.com/v1/engines/davinci-codex/completions";

            return await CallChatGPTApi(apiKey, endpoint, prompt);
        }

        static async Task<string> CallChatGPTApi(string apiKey, string endpoint, string inputText) {
            using (HttpClient client = new HttpClient()) {
                client.BaseAddress = new Uri(endpoint);

                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                // Prepare the request data
                var requestData = new {
                    prompt = inputText,
                    max_tokens = 150
                };

                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData));

                var response = await client.PostAsync("completions", content);

                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
