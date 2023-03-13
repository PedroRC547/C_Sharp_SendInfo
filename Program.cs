
using System.Net.Http.Headers;

namespace UtilizandoAPI
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://localhost:7078/api/Log"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "text/plain");

                    request.Content = new StringContent("{\n\n  \"mensagem\": \"{teset}\",\n  \"data_criacao\": 12032023\n\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }

    }
}