using System;
using FundamentosCSHARP.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;

namespace FundametosCSHARP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            var client = new HttpClient();

            Post post = new Post()
            {
                userId = 50,
                body = "Contenido del post",
                title = "Titulo del post"
            };

            var data = JsonSerializer.Serialize<Post>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await client.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<Post>(result);
            }
        }
    }
}